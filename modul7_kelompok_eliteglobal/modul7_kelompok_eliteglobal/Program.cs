// See https://aka.ms/new-console-template for more information
using modul7_kelompok_eliteglobal;

DataMahasiswa_1302210036 udin = new DataMahasiswa_1302210036();
udin.ReadJSON();

Console.WriteLine("");

TeamMembers_1302210036 elit = new TeamMembers_1302210036();
elit.ReadJSON();

Console.WriteLine("");

GlossaryItem gloss = new GlossaryItem();
gloss.ReadJson();
