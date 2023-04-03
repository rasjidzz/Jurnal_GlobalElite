using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using System.Text.Json.Nodes;

namespace modul7_kelompok_eliteglobal
{
    internal class GlossaryItem_1302210106_SteventRangga
    {
        public void ReadJson()
        {
            string json = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_3_1302210106.json");

            dynamic js = JsonConvert.DeserializeObject(json);
            dynamic jn = js.glossary.GlossDiv.GlossList.GlossEntry;



            Console.WriteLine(jn.ID);
            Console.WriteLine(jn.SortAs);
            Console.WriteLine(jn.GlossTerm);
            Console.WriteLine(jn.Acronym);
            Console.WriteLine(jn.Abbrev);
            
            Console.WriteLine(jn.GlossDef.para);
            Console.WriteLine(jn.GlossDef.GlossSeeAlso[0]);
            Console.WriteLine(jn.GlossDef.GlossSeeAlso[1]);
            Console.WriteLine(jn.GlossSee);

        }
    }
}
