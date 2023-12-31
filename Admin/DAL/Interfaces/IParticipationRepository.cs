﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IParticipationRepository
    {

        ParticipationModel GetDataById(string id);
        bool Create(ParticipationModel model);
        bool Update(ParticipationModel model);
        bool Delete(string id);


    }
}
