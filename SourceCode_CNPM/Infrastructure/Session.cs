﻿using System;

namespace Infrastructure
{
    public static class Session
    {
        public static string? UserID { get; private set; }
        public static string? Username { get; private set; }
        public static string? Role { get; private set; }

        public static void StartSession(string userId, string username, string role)
        {
            UserID = userId;
            Username = username;
            Role = role;
        }

        public static void EndSession()
        {
            UserID = null;
            Username = null;
            Role = null;
        }

        public static bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(UserID);
        }
    }

}
