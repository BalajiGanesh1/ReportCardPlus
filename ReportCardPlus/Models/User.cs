﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportCardPlus.Models
    {
    public class User
        {

        public long UserID { get; set; }
        public long StudentID { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }

        }
    }