
using BLLayer.CoachService;
using BLLayer.PlayerService;
using BLLayer.RefereeService;
using BLLayer.TeamService;

using System;
using System.Collections.Generic;
using System.Text;

namespace BLLayer
{
  public  class Factory
    {
        public static IPlayer GetPlayerModuleObject()
        {
            return new PlayerModule();
        }
        public static ICoach GetCoachModuleObject()
        {
            return new CoachModule();
        }
        public static IReferee GetRefereeModuleObject()
        {
            return new RefereeModule();
        }
        public static ITeam GetTeamModuleObject()
        {
            return new TeamModule();
        }
    }
}
