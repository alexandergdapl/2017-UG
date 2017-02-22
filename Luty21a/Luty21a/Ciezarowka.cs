using System;

namespace Luty21a
{
    class Ciezarowka : IPojazd
    {
        private string _rodzaj;
        private int _kola;
        private int _miejsca;        
        
        
        public void UstawRodzajPojazdu(string rodzaj)
        {
            _rodzaj = rodzaj;
        }

        public void UstawIloscKol(int kola)
        {
            _kola = kola;
        }

        public void UstawIloscMiejsc(int miejsca)
        {
            _miejsca = miejsca;
        }

       

        public string PobierzRodzajPojazdu()
        {
            return _rodzaj;
        }

        public int PobierzIloscKol()
        {
            return _kola;
        }

        public int PobierzIloscMiejsc()
        {
            return _miejsca;
        }
        
    }
}
