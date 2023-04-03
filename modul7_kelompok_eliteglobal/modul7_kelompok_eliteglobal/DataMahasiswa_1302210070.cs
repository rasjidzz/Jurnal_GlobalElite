using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul7_kelompok_eliteglobal
{
    internal class DataMahasiswa_1302210070
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_1_1302210070.json");
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonString);

            Console.WriteLine($"Nama: {jsonObject.firstName} {jsonObject.lastName}");
            Console.WriteLine($"Gender: {jsonObject.gender} dan Umur: {jsonObject.age}");
            Console.WriteLine($"Address: {jsonObject.address.streetAddress}, {jsonObject.address.city}, {jsonObject.address.state}");
            Console.WriteLine($"Courses: {jsonObject.courses[0].code}, {jsonObject.courses[0].name}");
            Console.WriteLine($"Courses: {jsonObject.courses[1].code}, {jsonObject.courses[1].name}");
        }
    }
}
