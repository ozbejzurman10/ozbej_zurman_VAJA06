using System.IO;

namespace vaja6 {

  
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {

        private int id;
        private string u_ime;
        private string u_geslo;
        private static int stIg = 1;

		// Provzeti konstruktor
        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        // Pretvordbeni
        public Igralec(string i, string g)
        {
            u_ime = i;
            u_geslo = g;
            id = stIg;
            stIg++;
        }

        //Kopirni
        public Igralec(Igralec i)
        {
            u_ime = i.u_ime;
            u_geslo = i.u_geslo;
            id = stIg;
            stIg++;
        }

        // Lastnost Id
        public int Id {
            get
            {
                return id;
            }
        }

		// Lastnost U_ime
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

		// Lastnost U_geslo
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
