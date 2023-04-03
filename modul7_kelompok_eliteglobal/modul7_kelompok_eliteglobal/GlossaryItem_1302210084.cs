using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class GlossaryItem_1302210084
    {
        public void ReadJSON()
        {
            String jS = File.ReadAllText(@"D:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_3_1302210084.json");
            dynamic jO = JsonConvert.DeserializeObject(jS);

            Console.WriteLine(jO.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine(jO.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine(jO.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine(jO.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine(jO.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine(jO.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            Console.WriteLine(jO.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[0]);
            Console.WriteLine(jO.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[1]);
            Console.WriteLine(jO.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);



        }
    }
}
