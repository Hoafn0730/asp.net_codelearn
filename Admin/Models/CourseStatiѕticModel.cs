﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class CourseStatiѕticModel
    {
        public int ParticipationId { get; set; }
        public int CourseId { get; set; }
        public string NameCourse { get; set; }
        public int Price { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
