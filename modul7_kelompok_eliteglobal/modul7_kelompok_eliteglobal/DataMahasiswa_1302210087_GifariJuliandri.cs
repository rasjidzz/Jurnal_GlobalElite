using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class DataMahasiswa_1302210087_GifariJuliandri
    {
        public void ReadJSON()
        {
            string json = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_1_1302210087.json");
            dynamic jsonGif = JsonConvert.DeserializeObject(json);

            Console.WriteLine($"Nama {jsonGif.firstName} {jsonGif.lastName} ");
            Console.WriteLine($"Gender:  {jsonGif.gender} ");
            Console.WriteLine($"Age:  {jsonGif.age} ");
            Console.WriteLine($"Addres:  Jalan {jsonGif.address.streetAddress}, Kota {jsonGif.address.city}, State {jsonGif.address.state}");
            Console.WriteLine($"Courses: Code {jsonGif.courses[0].code}, Nama Matakuliah {jsonGif.courses[0].name} ");
            Console.WriteLine($"Courses: Code {jsonGif.courses[1].code}, Nama MataKuliah {jsonGif.courses[1].name} ");
        }
    }
}
