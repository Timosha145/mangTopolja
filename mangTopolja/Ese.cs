using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangTopolja
{
    //    1.    Liides Üksus sisaldab
    interface IUksus
    {
        //1. int-tüüpi parameetriteta meetodit punktideArv;
        int punktideArv();

        //2. String-tüüpi parameetriteta meetodit info.
        string meetodInfo();
    }

    //    2. Klass Ese realiseerib liidese Üksus.
    class Ese : IUksus
    {
        //1. Klassis on privaatsed isendiväljad järgmise info jaoks: nimetus(String) ja punktide arv(int).
        private string nimetus;
        private int punktideArv;

        //2. Klassis peab olema kahe parameetriga konstruktor, mille abil saab määrata nimetuse ja punktide
        Ese(string nimetus, int punktideArv)
        {
            this.nimetus = nimetus;
            this.punktideArv = punktideArv;
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


    //List<Ese> eseList = new List<Ese>();

    //StreamReader sr = new StreamReader(@"..\..\..\info.txt");
    //string text;
    //        while ((text = sr.ReadLine()) != null)
    //        {
    //            string[] rida = text.Split(';');
    //            foreach (var item in rida)
    //            {
    //                eseList.Add(new Ese(rida[0], int.Parse(rida[1])));
    //            }             
    //        }
    //        sr.Close();
}
