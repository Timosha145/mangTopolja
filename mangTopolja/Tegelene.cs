using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangTopolja 
{
    //    3. Klass Tegelane realiseerib liidese Üksus.
    class Tegelene
    {
        //1. Klassis on privaatsed isendiväljad järgmise info jaoks: nimi(String) ja esemete nimekiri
        private string nimi;
        protected double m_value = 0.0;
        List<Ese> eseList = new List<Ese>();
        List<Tegelene> tegelased = new List<Tegelene>();

        //2. Klassis peab olema ühe parameetriga konstruktor, mille abil saab määrata nime.
        Tegelene(string nimi)
        {
            this.nimi = nimi;
        }

        //3. Äsjaloodud tegelasel ei ole ühtegi eset. Eseme lisamiseks peab olema meetod lisaEse, mis jätab argumendiks antud eseme meelde.
        public int lisaEse(int item)
        {
            return item;
        }

        //4. Meetod punktideArv tagastab punktide arvu.
        public int punktideArv()
        {
            int i = 0;
            foreach (Ese item in eseList)
            {
                i += item.punktideArv();
            }
            return i;
        }

        //5. Meetod info tagastab selle eseme nimetuse.
        public string meetodInfo(int esemeteArv)
        {
            string info = $"Tegelase nime - {nimi}, esemete arv - {esemeteArv}, punktide arv - {punktideArv()}";
            return info;
        }

        //6. Klassis peab olema ka meetod väljastaEsemed, kus väljastatakse ekraanile tegelase esemed nii, et iga ese on eraldi real.
        public void valjastaEsemed()
        {
            foreach (Ese item in eseList)
            {
                Console.WriteLine(item);
            }
        }

        //7. Klass Tegelane realiseerib liidese Comparable<Tegelane>, kusjuures compareTo meetod realiseeritakse nii, et võrdlemine toimub esemete arvu alusel. (Näidis kood)

        public int compareTo(Tegelene other)
        {
            if (other==null) return 1;
            return m_value.CompareTo(other.m_value);
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
    //6. Klassis peab olema ka meetod väljastaEsemed, kus väljastatakse ekraanile tegelase esemed nii, et iga ese on eraldi real.
    //7. Klass Tegelane realiseerib liidese Comparable<Tegelane>, kusjuures compareTo meetod
    //realiseeritakse nii, et võrdlemine toimub esemete arvu alusel. (Näidis kood)
