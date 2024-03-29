﻿namespace Domain
{
    public class User : IId
    {
        public int? Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Login: {Login}, Password: {Password}";
        }
    }
}
