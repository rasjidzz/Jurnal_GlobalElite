using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace modul7_kelompok_eliteglobal
{
    internal class DataMahasiswa_1302210106_SteventRangga
    {
        public void ReadJSON()
        {

            string jsonString = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_1_1302210106.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama    : {jsonObject.firstName} {jsonObject.lastName}");
            Console.WriteLine($"gender  : {jsonObject.gender}");
            Console.WriteLine($"age     : {jsonObject.age}");
            Console.WriteLine($"alamat  : jalan {jsonObject.address.streetAddress}  kota {jsonObject.address.city} provinsi {jsonObject.address.state}");
            Console.WriteLine($"Courses : code {jsonObject.courses[0].code} matkul {jsonObject.courses[0].name}");
            Console.WriteLine($"Courses : code {jsonObject.courses[1].code} matkul {jsonObject.courses[1].name}");
        }
    }
}
