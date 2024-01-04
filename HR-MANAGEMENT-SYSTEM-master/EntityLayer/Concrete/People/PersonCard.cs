﻿using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.People
{
    public class PersonCard : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int SysCompanyID { get; set; }
        public SysCompany SysCompany { get; set; }
        public int Gender { get; set; }
        public int MilitaryStatus { get; set; }
        public int MaritalStatus { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Body { get; set; }
        public int FootNumber { get; set; }
        public string DriverLicense { get; set; }
        public string BirthPlace { get; set; }
        public DateOnly BirthDate { get; set; }
        public int ID_No { get; set; }
        public string Serial_No { get; set; }
        public string Nationality { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public string LFile { get; set; }
        public DateTime EnteredAt { get; set; }
        public DateTime ExitedAt { get; set; }
    }
}
