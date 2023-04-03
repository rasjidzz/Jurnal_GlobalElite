using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class TeamMember_1302210087_Gifari_Juliandri
    {
        public void ReadJSON()
        {
            string json = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_2_1302210087.json");
            dynamic jsonGif = JsonConvert.DeserializeObject(json);

            Console.WriteLine("Team Membeer :");
            int iftar = 1;
            foreach (var members in jsonGif.members)
            {
                Console.WriteLine($" {iftar} {members.nim}-{members.firstName} {members.lastName}, umur: {members.age}, gender: {members.gender}  ");
                iftar++;
            }
        }
    }
}
