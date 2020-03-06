
﻿
using Domain;

using System;
using System.Collections.Generic;
using System.Text;


namespace BLLayer.RefereeService
{
    public class RefereeModule:IReferee
    {
        Repository.IRefereeModule _refereeObj;
        public RefereeModule()
        {
            _refereeObj = Repository.Factory.GetRefereeModuleObject();
        }
        public void addToFavouriteTeam(Referee referee)
        {
            _refereeObj.addToFavouriteTeam(referee);
        }

        public Referee GetRefereeById(int referee)
        {
            return _refereeObj.GetRefereeById(referee);
        }
    }
}
