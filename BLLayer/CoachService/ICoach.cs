
﻿using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLLayer.CoachService
{
   public interface ICoach
    {
        void plusForTeam(Coach coach);
        Coach GetCoachById(int coach);
    }
}
