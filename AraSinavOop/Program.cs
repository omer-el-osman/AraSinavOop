namespace AraSinavOop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }



        public class Personel
        {

            public string? personelAd { get; set; }
            public string? personelSoyad { get; set; }
            public string? Email { get; set; }
            public string? tc { get; set; }
            public string? no { get; set; }

            public string? kayit { get; set; }
      



            public string[] pro1()
            {
                List<string> tumpro = new List<string>();

                tumpro.Add(personelAd);
                tumpro.Add(personelSoyad);
                tumpro.Add(Email);
                tumpro.Add(tc);
                tumpro.Add(no);
                tumpro.Add(kayit);
             

                return tumpro.ToArray();


            }

            public class proje
            {

                public string? projeAd { get; set; }
                public string? projekonusu { get; set; }

                public string? baslangic { get; set; }
                public string? bitis { get; set; }
                public string? personelAd { get; set; }
                public string? durum { get; set; }
           


                public string[] gor1()
                {



                    List<string> tumpro = new List<string>();
                    tumpro.Add(projeAd);
                    tumpro.Add(projekonusu);

                    tumpro.Add(baslangic);
                    tumpro.Add(bitis);

                    tumpro.Add(personelAd);
                    tumpro.Add(durum);
                


                    return tumpro.ToArray();


                }
            }





        }




    }
}