using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalAPI.Areas.admin.Models
{
    public interface IPerson
    {
        string First_Name { get; set; }
        string Last_Name { get; set; }

        string GetFullName();

        int GetAge();
    }

    public class Police : IPerson
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Badge_Number { get; set; }
        public Police()
        {
            Badge_Number = Guid.NewGuid().ToString();

        }

        public int GetAge()
        {
            return 52;
        }

        public string GetFullName()
        {
            return First_Name + " " + Last_Name;
        }
    }

    public class Precint
    {
        public List<Police> SquadList { get; set; }
        public bool DeploydPolice { get; set; }
        public void GetSquad()
        {
            SquadList = new List<Police>();
            SquadList.Add(new Police { First_Name = "Nelson", Last_Name = "Vasquez" });
            SquadList.Add(new Police { First_Name = "Nelson", Last_Name = "Vasquez" });
            SquadList.Add(new Police { First_Name = "Neldson", Last_Name = "Vasquez" });
            SquadList.Add(new Police { First_Name = "Nelsdon", Last_Name = "Vasquez" });
            SquadList.Add(new Police { First_Name = "Nelsodsn", Last_Name = "Vasquez" });
            SquadList.Add(new Police { First_Name = "Nelsssson", Last_Name = "Vasquez" });
            SquadList.Add(new Police { First_Name = "Nsselson", Last_Name = "Vasquez" });

        }
        public void Deploy()
        {
            DeploydPolice = true;

        }
        public void Report()
        {
            foreach (Police p in SquadList)
            {
                p.GetFullName();
            }
        }
    }
    public class CrimeDepartment
    {
        public Precint precint { get; set; }
        public List<Witness> witness { get; set; }
        public List<Victim> victim { get; set; }
        public CrimeDepartment()
        {
            GetCaller();
            precint = new Precint();
            precint.GetSquad();
            precint.Report();
            precint.Deploy();
        }
        public void GetCaller()
        {
            witness = new List<Witness>();
        }
    }
    public class Victim : IPerson
    {
   
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public int GetAge()
        {
            return 33;
        }

        public string GetFullName()
        {
            return Last_Name + " " + First_Name;

        }
    }
    public class Witness: IPerson
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public int GetAge()
        {
            return Convert.ToInt32(Guid.NewGuid());
        }

        public string GetFullName()
        {
            return Last_Name + " " + First_Name;

        }
    }

}
