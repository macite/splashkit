//
//  web.cpp
//  splashkit
//
//  Created by Andrew Cain on 26/07/2016.
//  Copyright © 2016 Andrew Cain. All rights reserved.
//

#include "web.h"
#include "web_driver.h"
#include "utility_functions.h"
#include <fstream>
#include <cstdio>
#include <cstring>

#include "images.h"

struct _http_header_data
{
    string name;
    string value;
};

struct _http_request_data
{
    pointer_identifier id;

    // requestType: HttpMethod;
    string url;
    string version;
    //headername : StringArray;
    //headervalue: StringArray;
    string body;
};

struct _http_response_data
{
    pointer_identifier  id;
    sk_http_response    data;
};

sk_http_response make_request (sk_http_method request_type, string url, unsigned short port, string body)
{
    sk_http_request request;

    request.request_type = request_type;
    request.url = url.c_str();
    request.port = port;
    request.body = body.c_str();

    return sk_http_make_request(request);
}

http_response http_get(string url, unsigned short port)
{
    http_response response;

    response = new(_http_response_data);
    response->id = HTTP_RESPONSE_PTR;
    response->data = make_request(HTTP_GET, url, port, "");
    return response;
}

void save_response_to_file(http_response response, string filename)
{
    ofstream file(filename, ios::binary);
    file.write(response->data.data,response->data.size);
    file.close();
}

string http_response_to_string(http_response response)
{
    if ( ! VALID_PTR(response, HTTP_RESPONSE_PTR))
    {
        raise_warning("Attempt to convert invalid http response to a string");
        return "";
    }

    string result = "";

    for (int i = 0; i < response->data.size; i++)
    {
        // WriteLn(response^.data.data[i]);
        result += response->data.data[i];
    }
    return result;
}

bitmap download_image(string name, string url, unsigned short port)
{
    http_response response = http_get(url, port);

    if ( response->data.status < 200 || response->data.status >= 300 )
    {
        raise_warning("Unable to download image from " + url + " got status " + to_string(response->data.status));
        return nullptr;
    }

    char *tmpname = strdup("/tmp/splashkit.image.XXXXXX");
    mkstemp(tmpname);
    save_response_to_file(response, tmpname);

    bitmap result = load_bitmap(name, tmpname);
    remove(tmpname); // Delete the file

    free(tmpname);
    free_response(response);

    return result;
}

void free_response (http_response response)
{
    if ( VALID_PTR(response, HTTP_RESPONSE_PTR))
    {
        sk_free_response(&response->data);
        response->id = NONE_PTR;
        delete(response);
    }
    else
    {
        raise_warning("Attempting to delete a http response with an invalid pointer.");
    }
}
