using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace modul7_kelompok_eliteglobal
{
    internal class TeamMembers_1302210106_SteventRangga
    {
        public void ReadJson()
        {
            string json = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_2_1302210106.json");

            dynamic js = JsonConvert.DeserializeObject(json);

            Console.WriteLine("Daftar anggota kelompok:");
            int i = 1;
            foreach (var members in js.members)
            {
                Console.WriteLine($" {i} {members.nim} {members.firstName} {members.lastName} ({members.age}, {members.gender})");
                i++;
            }
        }
    }
}
