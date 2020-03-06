
﻿
using Domain;
using Repository;
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
            _refereeObj = Factory.GetRefereeModuleObject();
        }
        public void addToFavouriteTeam(Referee referee)
        {
            _refereeObj.addToFavouriteTeam(referee);
        }
       
    }
}
