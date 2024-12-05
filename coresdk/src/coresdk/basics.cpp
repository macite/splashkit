//
//  basics.cpp
//  splashkit
//
//  Created by Andrew Cain on 3/6/17.
//  Copyright © 2017 Andrew Cain. All rights reserved.
//

#include "basics.h"

#include <algorithm>
#include <cstdlib>

#include <functional>
#include <cctype>
#include <locale>

namespace splashkit_lib
{

    // trim see: https://stackoverflow.com/questions/216823/whats-the-best-way-to-trim-stdstring

    // trim from start
    string ltrim(const string &text)
    {
        string s = text;
        s.erase(s.begin(), std::find_if(s.begin(), s.end(), [](int c) { return !std::isspace(c);}));
        return s;
    }

    // trim from end
    string rtrim(const string &text)
    {
        string s = text;
        s.erase(std::find_if(s.rbegin(), s.rend(), [](int c) { return !std::isspace(c);}).base(), s.end());
        return s;
    }

    // trim from both ends
    string trim(const string &text)
    {
        return ltrim(rtrim(text));
    }

    string to_lowercase(const string &text)
    {
        string data = text;
        std::transform(data.begin(), data.end(), data.begin(), ::tolower);
        return data;
    }

    string to_uppercase(const string &text)
    {
        string data = text;
        std::transform(data.begin(), data.end(), data.begin(), ::toupper);
        return data;
    }

    int length_of(const string &text)
    {
        return text.length();
    }

    bool contains(const string &text, const string &subtext)
    {
        return index_of(text, subtext) != -1;
    }

    int index_of(const string &text, const string &subtext)
    {
        size_t pos = text.find(subtext);
        if (pos == string::npos)
            return -1;
        return static_cast<int>(pos);
    }

    string replace_all(const string &text, const string &substr, const string &newtext)
    {
        if (substr.empty())
            return text;
        
        string result = text;
        size_t pos = 0;
        while ((pos = result.find(substr, pos)) != string::npos)
        {
            result.replace(pos, substr.length(), newtext);
            pos += newtext.length();
        }
        return result;
    }

    vector<string> split(const string &text, char delimiter)
    {
        vector<string> result;
        string::size_type start = 0;
        string::size_type end = text.find(delimiter);
        while (end != string::npos)
        {
            result.push_back(text.substr(start, end - start));
            start = end + 1;
            end = text.find(delimiter, start);
        }
        result.push_back(text.substr(start));
        return result;
    }

    // integer check see: https://stackoverflow.com/questions/2844817/how-do-i-check-if-a-c-string-is-an-int#2845275

    bool is_integer(const string &text)
    {
        string s = trim(text);
        if(s.empty() || ((!isdigit(s[0])) && (s[0] != '-') && (s[0] != '+'))) return false;
        
        char * p;
        strtol(s.c_str(), &p, 10);
        
        return (*p == 0);
    }

    bool is_double(const string &text)
    {
        return is_number(text);
    }

    bool is_number(const string &text)
    {
        string s = trim(text);
        if(s.empty() || ((!isdigit(s[0])) && (s[0] != '-') && (s[0] != '+'))) return false;
        
        char * p;
        strtod(s.c_str(), &p);
        
        return (*p == 0);
    }

    int convert_to_integer(const string &text)
    {
        return std::stoi( text );
    }

    double convert_to_double(const string &text)
    {
        return std::stod( text );
    }
}
