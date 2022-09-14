using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangTopolja
{
    //    2. Klass Ese realiseerib liidese Üksus.
    public class Ese : IUksus
    {
        //1. Klassis on privaatsed isendiväljad järgmise info jaoks: nimetus(String) ja punktide arv(int).
        private string nimetus;
        private int PunktideArv;

        //2. Klassis peab olema kahe parameetriga konstruktor, mille abil saab määrata nimetuse ja punktide
        public Ese(int punktideArv, string nimetus)
        {
            this.nimetus = nimetus;
            this.PunktideArv = punktideArv;
        }

        //3. Meetod punktideArv tagastab punktide arvu.
        public int punktideArv()
        {
            return PunktideArv;
        }

        //4. Meetod info tagastab selle eseme nimetuse.
        public string meetodInfo()
        {
            Console.WriteLine(nimetus);
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
