﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wss.DoMain.Jwt
{
    public class TokenExpiredException : SignatureVerificationException
    {
        private const string PayloadDataKey = "PayloadData";
        private const string ExpirationKey = "Expiration";

        /// <summary>
        /// Creates an instance of <see cref="TokenExpiredException" />.
        /// </summary>
        /// <param name="message">The error message.</param>
        public TokenExpiredException(string message)
             : base(message)
        {
        }

        /// <summary>
        /// The payload.
        /// </summary>
        public IDictionary<string, object> PayloadData
        {
            get => GetOrDefault<Dictionary<string, object>>(PayloadDataKey);
            internal set => Data.Add(PayloadDataKey, value);
        }

        /// <summary>
        /// The expiration DateTime of the token.
        /// </summary>
        public DateTime? Expiration
        {
            get => GetOrDefault<DateTime?>(ExpirationKey);
            internal set => Data.Add(ExpirationKey, value);
        }
    }
}