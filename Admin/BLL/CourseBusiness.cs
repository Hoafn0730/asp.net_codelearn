﻿using BLL.Interfaces;
using DAL.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CourseBusiness : ICourseBusiness
    {
        private ICourseRepository _res;
        public CourseBusiness(ICourseRepository res)
        {
            _res = res;
        }

        public CourseModel GetDataById(string id) => _res.GetDataById(id);

        public bool Create(CourseModel model) =>  _res.Create(model);
        



    }
}
