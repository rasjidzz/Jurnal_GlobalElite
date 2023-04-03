using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class DataMahasiswa_1302213045
    {
        public void ReadJSON()
        {
            string JsonString = File.ReadAllText(@"E:\jurnal\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_1_nim.json");
            dynamic JsonObject = JsonConvert.DeserializeObject<dynamic>(JsonString);
            Console.WriteLine($"Nama : {JsonObject.firstName} {JsonObject.lastName} ");
            Console.WriteLine($"Gender : {JsonObject.gender}");
            Console.WriteLine($"Age : {JsonObject.age}");
            Console.WriteLine($"Alamat : {JsonObject.address.streetAddress}, {JsonObject.address.city}, {JsonObject.address.state}");
            Console.WriteLine($"Matakuliah 1 : {JsonObject.courses[0].code}, {JsonObject.courses[0].name}");
            Console.WriteLine($"Matakuliah 2 : {JsonObject.courses[1].code}, {JsonObject.courses[1].name}");
        }
    }
}
