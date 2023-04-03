using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class TeamMembers_1302210084
    {
        public void ReadJSON()
        {
            String jS = File.ReadAllText(@"D:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_2_1302210084.json");
            dynamic jO = JsonConvert.DeserializeObject(jS);

            Console.WriteLine("Team member list:");
            foreach(var mem in jO.members)
            {
                Console.WriteLine($"{mem.nim} {mem.firstName +" "+ mem.lastName} ({mem.age} {mem.gender})");
            }
        }
    }
}
