﻿using Otel.businneslogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel.EntityLayer
{
    internal class eloda
    {



        private int odaDurum;
        private int odaNo;



        public int ODADURUM { get { return odaDurum; } set { odaDurum = value; } }
        public int ODANO { get { return odaNo; } set { odaNo = value; } }

        public eloda( int odaNo)
        {
           

            this.odaNo = odaNo;
            

        }
        public override string ToString()
        {
            return "-" + this.odaNo;
        }
       
    }
}
