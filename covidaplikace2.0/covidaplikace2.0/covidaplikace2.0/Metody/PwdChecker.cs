namespace covidaplikace2._0
{
    class PwdChecker
    {
        //Zjistí zda je heslo a potvrzovací heslo stejné
        public bool Same(string password, string password2)
        {
            if (password == password2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Zjistí zda je délka hesla dostatečná
        public bool DelkaHesla(string password)
        {
            if (password.Length > 8)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Výpis jak to heslo je silné
        public object Check(string password, string password2)
        {
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string cisla = "0123456789";
            string specialChars = "#?!,-'/`_*$";
            int score = 0;

            if (Contains(password, upperCase))
            {
                score++;
            }

            if (Contains(password, lowerCase))
            {
                score++;
            }

            if (Contains(password, cisla))
            {
                score++;
            }

            if (Contains(password, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 4:
                    return "Velice silné heslo";
                case 3:
                    return "Silné heslo";
                case 2:
                    return "Průměrné heslo, zkuste doplnit číslici/speciální znak/velké písmeno";
                case 1:
                    return "Heslo je slabé, zkuste doplnit číslici/speciální znak/velké písmeno";
                default:
                    return "Heslo je slabé, zkuste doplnit číslici/speciální znak/velké písmeno";
            }
        }
        //metoda hledajici znaky v textu
        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }
}
