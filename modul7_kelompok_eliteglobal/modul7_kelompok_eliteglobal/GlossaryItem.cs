using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class GlossaryItem
    {
        public void ReadJson()
        {
            string JSONStr = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_3_1302210036.json");

            dynamic js = JsonConvert.DeserializeObject<dynamic>(JSONStr);
            dynamic jsn = js.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine(jsn.ID);
            Console.WriteLine(jsn.SortAs);
            Console.WriteLine(jsn.GlossTerm);
            Console.WriteLine(jsn.Acronym);
            Console.WriteLine(jsn.Abbrev);
            Console.WriteLine(jsn.GlossDef.para);
            Console.WriteLine(jsn.GlossDef.GlossSeeAlso[0]);
            Console.WriteLine(jsn.GlossDef.GlossSeeAlso[1]);
            Console.WriteLine(jsn.GlossSee);

        }
    }
}
