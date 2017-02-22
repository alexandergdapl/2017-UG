namespace ZadanieCzwarteV3
{
    class Service
    {
        private readonly Chlopcy _chlopcy = new Chlopcy();
        private readonly Dziewczyny _dziewczyny = new Dziewczyny();

        private readonly DrukujTablice _wydrukuj = new DrukujTablice();
        private readonly DrukujTablice2 _wydrukuj2 = new DrukujTablice2();


        public void StartChlopcy()
        {
            var chlopaki = _chlopcy.UtworzTablice();
            _wydrukuj.DrukTablicy(chlopaki);
        }

        public void StartDziewczyny()
        {
            string[] dziewczynki = _dziewczyny.UtworzTablice();
            _wydrukuj.DrukTablicy(dziewczynki);
        }

        public void ScalanieTablic()
        {
            var chlopaki = _chlopcy.UtworzTablice();
            string[] dziewczynki = _dziewczyny.UtworzTablice();


            var pary = new string[5,2];

            for (int i = 0; i < 5; i++)
            {
                    pary[i,0] = chlopaki[i];
                    pary[i,1] = dziewczynki[i];
                
            }
            _wydrukuj2.DrukTablicy2(pary);
        }
    }
}


