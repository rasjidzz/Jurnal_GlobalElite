using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class GlossaryItem_1302213045
    {
        public void ReadJSON()
        {
            string JsonString = File.ReadAllText(@"E:\jurnal\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_3_1302213045.json");
            dynamic JsonObject = JsonConvert.DeserializeObject<dynamic>(JsonString);
            dynamic Glossentr = JsonObject.glossary.GlossDiv.GlossList.GlossEntry;
            Console.WriteLine("Isi Data Dari GlossEntry : ");
            Console.WriteLine(Glossentr.ID);
            Console.WriteLine(Glossentr.SortAs);
            Console.WriteLine(Glossentr.GlossTerm);
            Console.WriteLine(Glossentr.Acronym);
            Console.WriteLine(Glossentr.Abbrev);
            Console.WriteLine(Glossentr.GlossDef.para);
            Console.WriteLine(Glossentr.GlossDef.GlossSeeAlso[0]);
            Console.WriteLine(Glossentr.GlossDef.GlossSeeAlso[1]);
            Console.WriteLine(Glossentr.GlossSee);
        }
    }
}
