﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Services
{
    public class Encrypt
    {
        public static string GenerateSha256Hash(String input) {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            System.Security.Cryptography.SHA512Managed sHA = new System.Security.Cryptography.SHA512Managed();
            byte[] hash = sHA.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-",""); 
        }
    }
}
