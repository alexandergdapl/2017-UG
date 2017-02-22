using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luty21a
{
    public interface IPojazd
    {
        void UstawRodzajPojazdu(string rodzaj);
        void UstawIloscKol(int kola);
        void UstawIloscMiejsc(int miejsca);
        
    }
}
