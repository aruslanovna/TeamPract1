
﻿using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLLayer.CoachService
{
   public class CoachModule:ICoach
    {
        Repository.ICoachModule _coachObj;
        public CoachModule()
        {
            _coachObj = Factory.GetCoachModuleObject();
        }

        public void plusForTeam(Coach coach)
        {
            _coachObj.plusForTeam(coach);
        }
    }
}
