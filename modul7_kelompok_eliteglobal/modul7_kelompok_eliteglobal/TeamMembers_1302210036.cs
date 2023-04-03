using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class TeamMembers_1302210036
    {
        public void ReadJSON()
        {
            string JSONStr = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_2_1302210036.json");
            dynamic JSONObj = JsonConvert.DeserializeObject<dynamic>(JSONStr);

            int i = 0;
            Console.WriteLine("Daftar anggota kelompok : ");
            foreach (var members in JSONObj.members)
            {
                Console.WriteLine($"Nama Member: {i} {members.nim} {members.firstName} {members.lastName} ({members.age} {members.gender})");
                i++;
            }
        }
    }
}
