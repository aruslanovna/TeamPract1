using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
  public  class Factory
    {
        public static IPlayerModule GetPlayerModuleObject()
        {
            return new PlayerModule();
        }
        public static ICoachModule GetCoachModuleObject()
        {
            return new CoachModule();
        }
        public static IRefereeModule GetRefereeModuleObject()
        {
            return new RefereeModule();
        }
        public static ITeamModule GetTeamModuleObject()
        {
            return new TeamModule();
        }
    }
}
