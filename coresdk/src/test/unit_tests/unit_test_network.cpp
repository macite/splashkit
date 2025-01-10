#include "catch.hpp"

#include "networking.h"

using namespace splashkit_lib;

TEST_CASE("can create a server", "[networking]")
{
    constexpr unsigned short int PORT = 3000;

    SECTION("can create a UDP server")
    {
        const string SERVER_NAME = "test_server";
        
        server_socket server = create_server(SERVER_NAME, PORT, UDP);
        REQUIRE(server != nullptr);
        REQUIRE(has_server(SERVER_NAME));

        SECTION("can close a server")
        {
            REQUIRE(close_server(server));
        }
    }
    SECTION("can create a TCP server")
    {
        const string SERVER_NAME = "test_server_2";
        
        server_socket server = create_server(SERVER_NAME, PORT, TCP);
        REQUIRE(server != nullptr);
        REQUIRE(has_server(SERVER_NAME));
        SECTION("can close a server")
        {
            REQUIRE(close_server(server));
        }
    }
    SECTION("can check for non-existent server")
    {
        REQUIRE_FALSE(has_server("non_existent_server"));
    }
}
TEST_CASE("can communicate with server", "[networking]")
{
    constexpr unsigned short int PORT = 3001;
    const string TEST_IP = "localhost";
    
    SECTION("can communicate with a TCP server")
    {
        const string SERVER_NAME = "test_server_3";
        const string CONNECTION_NAME = "test_connection";
        server_socket server;

        SECTION("can create server with no connections")
        {
            server = create_server(SERVER_NAME, PORT, TCP);
            REQUIRE(server != nullptr);
            REQUIRE(has_server(SERVER_NAME));

            REQUIRE_FALSE(has_connection(CONNECTION_NAME));
            REQUIRE(connection_count(server) == 0);
            REQUIRE(new_connection_count(server) == 0);
            REQUIRE_FALSE(server_has_new_connection(server));
            REQUIRE_FALSE(server_has_new_connection(SERVER_NAME));
            REQUIRE_FALSE(has_new_connections());
        }
        
        connection conn = open_connection(CONNECTION_NAME, TEST_IP, PORT, TCP);
        REQUIRE(conn != nullptr);

        REQUIRE(accept_new_connection(server));
        REQUIRE(has_connection(CONNECTION_NAME));
        REQUIRE(connection_count(server) == 1);

        connection last_conn = last_connection(server);

        REQUIRE(is_connection_open(conn));

        REQUIRE(close_server(server));
    }
    SECTION("can communicate with a UDP server")
    {
        const string SERVER_NAME = "test_server_4";
        const string CONNECTION_NAME = "test_connection_2";
        
        server_socket server;
        SECTION("can create server with no connections")
        {
            server = create_server(SERVER_NAME, PORT, UDP);

            REQUIRE(server != nullptr);
            REQUIRE(has_server(SERVER_NAME));

            REQUIRE_FALSE(has_connection(CONNECTION_NAME));
            REQUIRE(connection_count(server) == 0);
            REQUIRE(new_connection_count(server) == 0);
            REQUIRE_FALSE(server_has_new_connection(server));
            REQUIRE_FALSE(server_has_new_connection(SERVER_NAME));
        }
        
        connection conn = open_connection(CONNECTION_NAME, TEST_IP, PORT, UDP);
        REQUIRE(conn != nullptr);

        REQUIRE(has_connection(CONNECTION_NAME));

        connection last_conn = last_connection(server);
        REQUIRE(is_connection_open(conn));

        REQUIRE(close_server(server));
    }
    SECTION("can check for non-existant connection")
    {
        REQUIRE_FALSE(has_connection("non_existent_connection"));
    }
    SECTION("can check for error connecting to server")
    {
        connection conn = open_connection("test_connection_3", TEST_IP, PORT, TCP);
        REQUIRE_FALSE(is_connection_open(conn));

        const string INVALID_IP = "invalid_ip";
        connection conn2 = open_connection("test_connection_4", INVALID_IP, PORT, TCP);
        REQUIRE_FALSE(is_connection_open(conn2));
    }
}
TEST_CASE("can convert network data")
{
    SECTION("can convert hexidecimal to ipv4")
    {
        REQUIRE(hex_str_to_ipv4("0x7F000001") == "127.0.0.1");
        REQUIRE(hex_str_to_ipv4("0x00000000") == "0.0.0.0");
        REQUIRE(hex_str_to_ipv4("0x00000000000000") == "0.0.0.0");
        REQUIRE(hex_str_to_ipv4("0xFFFFFFFF") == "255.255.255.255");
        REQUIRE_THROWS(hex_str_to_ipv4(""));
        REQUIRE_THROWS(hex_str_to_ipv4("0x"));
        REQUIRE_THROWS(hex_str_to_ipv4("error"));
    }
    SECTION("can convert hexadecimal to decimal string")
    {
        REQUIRE(hex_to_dec_string("0x7F") == "127");
        REQUIRE(hex_to_dec_string("0x00") == "0");
        REQUIRE(hex_to_dec_string("0xFF") == "255");
        REQUIRE(hex_to_dec_string("") == "0");
        REQUIRE(hex_to_dec_string("0x") == "0");
        REQUIRE(hex_to_dec_string("0xGG") == "0");
        REQUIRE(hex_to_dec_string("error") == "0");
    }
    SECTION("can convert decimal to hexadecimal string")
    {
        REQUIRE(dec_to_hex(127) == "0x7F");
        REQUIRE(dec_to_hex(0) == "0x0");
        REQUIRE(dec_to_hex(255) == "0xFF");
        REQUIRE(dec_to_hex(256) == "0x100");
    }
    SECTION("can convert ipv4 to hexidecimal")
    {
        REQUIRE(ipv4_to_hex("127.0.0.1") == "0x7F000001");
        REQUIRE(ipv4_to_hex("255.255.255.255") == "0xFFFFFFFF");
        REQUIRE(ipv4_to_hex("0.0.0.0") == "0x00000000");
        REQUIRE(ipv4_to_hex("....") == "0x00000000");
        REQUIRE(ipv4_to_hex("") == "0x00000000");
        REQUIRE_THROWS(ipv4_to_hex("a.b.c.d"));
        REQUIRE_THROWS(ipv4_to_hex("error"));
    }
    SECTION("can convert ipv4 to decimal")
    {
        REQUIRE(ipv4_to_dec("127.0.0.1") == 2130706433);
        REQUIRE(ipv4_to_dec("0.0.0.0") == 0);
        REQUIRE(ipv4_to_dec("255.255.255.255") == 4294967295);
        REQUIRE(ipv4_to_dec("....") == 0);
        REQUIRE_THROWS(ipv4_to_dec("a.b.c.d"));
        REQUIRE_THROWS(ipv4_to_dec("error"));
    }
    SECTION("can convert decimal to ipv4")
    {
        REQUIRE(ipv4_to_str(2130706433) == "127.0.0.1");
        REQUIRE(ipv4_to_str(0) == "0.0.0.0");
        REQUIRE(ipv4_to_str(4294967295) == "255.255.255.255");
    }
    SECTION("can create name for connection")
    {
        REQUIRE(name_for_connection("splashkit.com", 3000) == "splashkit.com:3000");
        REQUIRE(name_for_connection("localhost", 3200) == "localhost:3200");
        REQUIRE(name_for_connection("", 0) == ":0");
    }
}