﻿/**
 * Author:    Olivia Flynn
 * Created:   14/12/2018
 *            City & Guilds Task A Class DataRecord
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDatabase
{
    public class DataRecord
    {
        public string VehicleRegNo { get; set; }
        public string EngineSize { get; set; }
        public string Make { get; set; }
        public string RentalPerDay { get; set; }
        public string DateRegistered { get; set; }
        public bool Available { get; set; }
    }
}
