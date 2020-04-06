using System;
using System.Collections.Generic;
using System.Text;

namespace EstonianData
{
    class ESTdata
    {
        public string Status { get; set; }
        public Results Results { get; set; }
        public bool Value { get;  set; }
    }
    public class Results
    {
        public string name { get; set; }
        public string cioc { get; set; }
        public string domain { get; set; }
        public string capital { get; set; }
        public string region { get; set; }
        public string population { get; set; }
        public string language { get; set; }
    }
}


/*
Display:
name
cioc
domain
capital
region
population
language
*/
