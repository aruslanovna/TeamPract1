
﻿using Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace BLLayer.CoachService
{
   public class CoachModule:ICoach
    {
        readonly Repository.ICoachModule _coachObj;
        public CoachModule()
        {
            _coachObj = Repository.Factory.GetCoachModuleObject();
        }

        public Coach GetCoachById(int coach)
        {
           return _coachObj.GetCoachById(coach);
        }

        public void plusForTeam(Coach coach)
        {
            _coachObj.plusForTeam(coach);
        }
    }
}
