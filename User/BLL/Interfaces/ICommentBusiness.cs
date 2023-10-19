﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICommentBusiness
    {

        bool Create(CommentModel model);
        bool Update(CommentModel model);
        bool Delete(string id);


    }
}
