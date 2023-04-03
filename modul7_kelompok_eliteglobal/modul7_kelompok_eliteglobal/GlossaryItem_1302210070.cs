using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class GlossaryItem_1302210070
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_3_130221070.json");
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonString);
            dynamic glosent = jsonObject.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("\nPrint Gloss Entry");
            Console.WriteLine(glosent.ID);
            Console.WriteLine(glosent.SortAs);
            Console.WriteLine(glosent.GlossTerm);
            Console.WriteLine(glosent.Acronym);
            Console.WriteLine(glosent.Abbrev);
            Console.WriteLine(glosent.GlossDef.para);
            Console.WriteLine(glosent.GlossDef.GlossSeeAlso[0]);
            Console.WriteLine(glosent.GlossDef.GlossSeeAlso[1]);
            Console.WriteLine(glosent.GlossSee);
        }
    }
}

