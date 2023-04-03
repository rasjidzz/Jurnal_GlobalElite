using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class TeamMember_1302213045
    {
        public void ReadJSON()
        {
            string JsonString = File.ReadAllText(@"E:\jurnal\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_2_1302213045.json");
            dynamic JsonObject = JsonConvert.DeserializeObject<dynamic>(JsonString);

            Console.WriteLine("Team Elite Global List : ");
            int i = 0;
            foreach (var mem in JsonObject.members)
            {
                Console.WriteLine($"{JsonObject.members[i].nim}, {JsonObject.members[i].firstName + " "+JsonObject.members[i].lastName} ({JsonObject.members[i].age}, {JsonObject.members[i].gender})");
                i++;
            }
        }
    }
}
