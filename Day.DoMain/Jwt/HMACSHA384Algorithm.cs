﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Wss.DoMain.Jwt
{
    public sealed class HMACSHA384Algorithm : IJwtAlgorithm
    {
        public byte[] Sign(byte[] key, byte[] bytesToSign)
        {
            using (var sha = new HMACSHA384(key))
            {
                return sha.ComputeHash(bytesToSign);
            }
        }

        /// <inheritdoc />
        public string Name => JwtHashAlgorithm.HS384.ToString();

        /// <inheritdoc />
        public bool IsAsymmetric { get; } = false;
    }
}
