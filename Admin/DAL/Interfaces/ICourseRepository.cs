﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICourseRepository
    {
        CourseModel GetDataById(string id);

        bool Create(CourseModel model);

        bool Update(CourseModel model);
    }
}
