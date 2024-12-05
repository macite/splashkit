//
// SplashKit Generated Basics C++ Code
// DO NOT MODIFY
//

#ifndef __basics_h
#define __basics_h

#include <string>
#include <vector>
#include <cstdint>
using std::string;
using std::vector;

bool contains(const string &text, const string &subtext);
double convert_to_double(const string &text);
int convert_to_integer(const string &text);
int index_of(const string &text, const string &subtext);
bool is_double(const string &text);
bool is_integer(const string &text);
bool is_number(const string &text);
int length_of(const string &text);
string replace_all(const string &text, const string &substr, const string &newtext);
vector<string> split(const string &text, char delimiter);
string to_lowercase(const string &text);
string to_uppercase(const string &text);
string trim(const string &text);

#endif /* __basics_h */
