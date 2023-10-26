﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogObject
{
    public class Account
    {
        private static Account instance = null; private static readonly object instanceLock = new object();
        private Account() { }
        public static Account Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new Account();
                    }
                    return instance;
                }
            }
        }
        public string Email { get; set; }
        public string Pass { get; set; }
        public bool Remember { get; set; }
    }
}