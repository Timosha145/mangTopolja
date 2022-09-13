using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangTopolja 
{
    //    3. Klass Tegelane realiseerib liidese Üksus.
    class Tegelene : IUksus
    {
        //1. Klassis on privaatsed isendiväljad järgmise info jaoks: nimi(String) ja esemete nimekiri
        private string nimi;
        List<Ese> eseList = new List<Ese>();

        //2. Klassis peab olema ühe parameetriga konstruktor, mille abil saab määrata nime.
        Tegelene(string nimi)
        {
            this.nimi = nimi;
        }

        //3. Äsjaloodud tegelasel ei ole ühtegi eset. Eseme lisamiseks peab olema meetod lisaEse, mis jätab argumendiks antud eseme meelde.
        public void lisaEse()
        {
            Tegelene tegelene = new Tegelene(nimi);
        }

        //3. Meetod punktideArv tagastab punktide arvu.
        int IUksus.punktideArv()
        {
            return punktideArv;
        }

        //4. Meetod info tagastab selle eseme nimetuse.
        public string meetodInfo()
        {
            return nimetus;
        }
    }
}

    //        3. Klass Tegelane realiseerib liidese Üksus.
    //1. Klassis on privaatsed isendiväljad järgmise info jaoks: nimi(String) ja esemete nimekiri
    //(List<Ese>).
    //2. Klassis peab olema ühe parameetriga konstruktor, mille abil saab määrata nime.
    //3. Äsjaloodud tegelasel ei ole ühtegi eset. Eseme lisamiseks peab olema meetod lisaEse, mis jätab
    //argumendiks antud eseme meelde.
    //4. Meetod punktideArv tagastab tegelase esemete punktide arvude summa.
    //5. Meetod info tagastab tegelase info tekstina, näidates tegelase nime, esemete arvu ja punktide
    //arvu.
    //6. Klassis peab olema ka meetod väljastaEsemed, kus väljastatakse ekraanile tegelase esemed nii,
    //et iga ese on eraldi real.
    //7. Klass Tegelane realiseerib liidese Comparable<Tegelane>, kusjuures compareTo meetod
    //realiseeritakse nii, et võrdlemine toimub esemete arvu alusel. (Näidis kood)