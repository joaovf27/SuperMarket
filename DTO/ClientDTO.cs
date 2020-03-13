﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ClientDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Phone { get; set; }
        public DateTime DateBirth { get; set; }
        public string Password { get; set; }
    }
}