using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace modul7_kelompok_eliteglobal
{
    internal class DataMahasiswa_1302210036
    {
        public void ReadJSON()
        {

            string jsonString = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_1_1302210036.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama: {jsonObject.firstName} {jsonObject.lastName}");
            Console.WriteLine($"Gender: {jsonObject.gender}");
            Console.WriteLine($"Umur: {jsonObject.age}");
            Console.WriteLine($"Memiliki alamat: {jsonObject.address.streetAddress}, {jsonObject.address.city}, {jsonObject.address.state}");
            Console.WriteLine($"Course: {jsonObject.courses[0].code} dengan nama {jsonObject.courses[0].name}");
            Console.WriteLine($"Course: {jsonObject.courses[1].code} dengan nama {jsonObject.courses[1].name}");
        }
    }
}
