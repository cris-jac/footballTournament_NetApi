﻿namespace Security
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
    }
}
