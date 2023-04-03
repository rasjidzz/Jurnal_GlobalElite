using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class DataMahasiswa_1302210084
    {
        public void ReadJSON()
        {
            String jS = File.ReadAllText(@"D:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_1_1302210084.json");
            dynamic jO = JsonConvert.DeserializeObject(jS);

            Console.WriteLine($"Nama {jO.firstName + " " + jO.lastName} dengan jenis kelamin {jO.gender} yang berumur {jO.age} yang tinggal di {jO.address.streetAddress} " +
                $"kota {jO.address.city} provinsi {jO.address.state}. " +
                $"Mengambil matakuliah {jO.courses[0].code + " - " + jO.courses[0].name + " dan " + jO.courses[1].code + " - " + jO.courses[1].name}");
        }
    }
}
