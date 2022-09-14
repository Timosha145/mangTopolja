using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangTopolja 
{
    //    3. Klass Tegelane realiseerib liidese Üksus.
    class Tegelene : IUksus, IComparable<Tegelene>
    {
        //1. Klassis on privaatsed isendiväljad järgmise info jaoks: nimi(String) ja esemete nimekiri
        private string nimi;
        List<Ese> eseList;

        //2. Klassis peab olema ühe parameetriga konstruktor, mille abil saab määrata nime.
        public Tegelene(string nimi)
        {
            this.nimi = nimi;
            eseList = new List<Ese>();
        }

        //3. Äsjaloodud tegelasel ei ole ühtegi eset. Eseme lisamiseks peab olema meetod lisaEse, mis jätab argumendiks antud eseme meelde.
        public int lisaEse(int arv)
        {
            return arv;
        }

        public void Equip(Ese ese) { eseList.Add(ese); }

        //4. Meetod punktideArv tagastab punktide arvu.
        public int punktideArv()
        {
            int summa = 0;
            foreach (Ese ese in eseList)
            {
                summa += ese.punktideArv();
            }
            return summa;
        }

        //5. Meetod info tagastab selle eseme nimetuse.
        public string meetodInfo()
        {
            string teg_info = $"Tegelase nime - {nimi}, esemete arv - {eseList.Count}, punktide arv - {punktideArv()}";
            return teg_info;
        }

        //6. Klassis peab olema ka meetod väljastaEsemed, kus väljastatakse ekraanile tegelase esemed nii, et iga ese on eraldi real.
        public void valjastaEsemed()
        {
            foreach (Ese ese in eseList)
            {
                Console.WriteLine(ese.meetodInfo());
            }
        }

        //7. Klass Tegelane realiseerib liidese Comparable<Tegelane>, kusjuures compareTo meetod realiseeritakse nii, et võrdlemine toimub esemete arvu alusel. (Näidis kood)

        public int CompareTo(Tegelene? muu)
        {
            if (muu==null)
            {
                return 1;
            }
            return this.eseList.Count - muu.eseKogus();
        }
        private int eseKogus() { return this.eseList.Count; }
        
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
