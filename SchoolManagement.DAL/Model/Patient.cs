﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DAL.Model
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name  { get; set; }
        public int Age { get; set; }
        public string TypeId { get; set; }

    }
}
