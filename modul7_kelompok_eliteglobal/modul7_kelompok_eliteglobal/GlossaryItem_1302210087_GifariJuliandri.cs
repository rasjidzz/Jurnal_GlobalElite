using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_eliteglobal
{
    internal class GlossaryItem_1302210087_GifariJuliandri
    {

        public void ReadJSON()
        {
            string json = File.ReadAllText(@"E:\Jurnal_GlobalElite\modul7_kelompok_eliteglobal\modul7_kelompok_eliteglobal\jurnal7_3_1302210087.json");
            dynamic jsonGif = JsonConvert.DeserializeObject(json);
            dynamic glossGif = jsonGif.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine(glossGif.ID);
            Console.WriteLine(glossGif.SortAs);
            Console.WriteLine(glossGif.GlossTerm);
            Console.WriteLine(glossGif.Acronym);
            Console.WriteLine(glossGif.Abbrev);
            Console.WriteLine(glossGif.GlossDef.para);
            Console.WriteLine(glossGif.GlossDef.GlossSeeAlso[0]);
            Console.WriteLine(glossGif.GlossDef.GlossSeeAlso[1]);
            Console.WriteLine(glossGif.GlossSee);


        }
    }
}