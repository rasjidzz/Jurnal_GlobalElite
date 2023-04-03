using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class TeamMembers_1302210070
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_2_1302210070.json");
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonString);

            Console.WriteLine();
            Console.WriteLine("Team Member: ");
            int iter = 1;
            foreach(var member in jsonObject.members)
            {
                Console.WriteLine($"{member.nim}-{member.firstName} {member.lastName}, {member.age}, {member.gender}");
                iter++;
            }
        }
    }
}
