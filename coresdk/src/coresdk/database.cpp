//
//  database.cpp
//  splashkit
//
//  Created by Jake Renzella on 2/08/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include "database.h"
#include "database_driver.h"
#include "resources.h"
#include "backend_types.h"
#include "utility_functions.h"

#include <vector>
#include <algorithm>
#include <iostream>
#include <map>

using namespace std;

static map<string, database> _databases;
static vector<query_result> _queries_vector;

struct _database
{
    pointer_identifier id;
    sk_database database;
    string filename, name;
};

bool has_database(string name)
{
    return _databases.count(name) > 0;
}

database database_named(string name)
{
    if (has_database(name))
    {
        return _databases[name];
    }
    else
    {
        return nullptr;
    }
}

int rows_changed(database db)
{
    return sk_rows_affected(db->database);
}

query_result run_sql(database db, string sql)
{
    sk_query_result temp_result = sk_prepare_statement(db->database, sql);
    sk_step_statement(&temp_result);

    query_result result = new sk_query_result();
    *result = temp_result;
    
    _queries_vector.push_back(result);
    
    return result;
}

query_result run_sql(string database_name, string sql)
{
    return run_sql(database_named(database_name), sql);
}

void free_query_result(query_result query)
{
    vector<query_result>::iterator it;
    
    it = find (_queries_vector.begin(), _queries_vector.end(), query);
    if (it != _queries_vector.end())
    {
        auto index = std::distance(_queries_vector.begin(), it);
        sk_finalise_query(*_queries_vector.at(index));
        _queries_vector.erase(it);
        delete(query);
    }
    else
    {
        raise_warning("Not able to remove query as it is not found in _queries_vector\n");
    }
}

void free_all_query_results()
{
    auto it = std::begin(_queries_vector);
    while (it != std::end(_queries_vector))
    {
        auto index = std::distance(_queries_vector.begin(), it);
        free_query_result(_queries_vector.at(index));
    }
    _queries_vector.clear();
}

bool get_next_row(query_result result)
{
    return sk_query_get_next_row(result);
}

bool has_row(query_result result)
{
    return sk_query_has_data(*result);
}

void reset_query_result(query_result result)
{
    sk_reset_query_statement(result);
}

int query_column_for_int(query_result result, int col)
{
    return sk_query_read_column_int(*result, col);
}

double query_column_for_double(query_result result, int col)
{
    return sk_query_read_column_double(*result, col);
}

string query_column_for_string(query_result result, int col)
{
    return sk_query_read_column_text(*result, col);
}

bool query_column_for_bool(query_result result, int col)
{
    return sk_query_read_column_bool(*result, col);
}

string query_type_of_col(query_result result, int col)
{
    return sk_query_type_of_column(*result, col);
}

bool query_success(query_result result)
{
    return sk_query_success(*result);
}

database open_database(string name, string filename)
{
    if (has_database(name)) return database_named(name);
    
    string file_path = path_to_resource(filename, DATABASE_RESOURCE);
    
    database result = new _database();
    
    result->id = DATABASE_PTR;
    result->filename = file_path;
    result->name = name;
    result->database = sk_open_database(file_path);
    
    // Unable to load database
    if ( ! result->database._data )
    {
        result->id = NONE_PTR;
        delete result;
        raise_warning ( cat({ "Error loading database ", name, " at (", file_path, ")"}) );
        return nullptr;
    }
    
    _databases[name] = result;
    return result;
}

void free_database(database db_to_close)
{
    if (VALID_PTR(db_to_close, DATABASE_PTR))
    {
        _databases.erase(db_to_close->name);
        sk_close_database(db_to_close->database);
        db_to_close->id = NONE_PTR;  // ensure future use of this pointer will fail...
        delete(db_to_close);
    }
    else
    {
        raise_warning("Delete sound effect called without valid sound effect");
    }
}

void free_database(string name_of_db_to_close)
{
    free_database(database_named(name_of_db_to_close));
}

void free_all_databases()
{
    size_t sz = _databases.size();
    
    for(size_t i = 0; i < sz; i++)
    {
        database db_to_close = _databases.begin()->second;
        if (VALID_PTR(db_to_close, DATABASE_PTR))
        {
            free_database(db_to_close);
        }
        else
        {
            raise_warning("Database contained an invalid pointer");
            _databases.erase(_databases.begin());
        }
    }
}