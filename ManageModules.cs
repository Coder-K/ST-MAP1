using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_MAP1
{
    public class ManageModules
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public double Required { get; set; }
        public int Done { get; set; }
        public int Points { get; set; }

        public ManageModules()
        {   }
        public ManageModules(string code , string name , double req , int points)
        {
            Code = code;
            Name = name;
            Required = req;
            Points = points;
        }

       // ArrayList Details = new ArrayList();
        public List<ManageModules> Details = new List<ManageModules>();

        public Dictionary<String, double > DetailsDict = new Dictionary<String, double>();

        public void AddingModule(string code, string name, double req, int points)
        {
          //  Details.Add( new ManageModules(code ,name , req ,points));
            DetailsDict.Add(name,req);
        
        }
    }
}
