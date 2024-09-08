using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Interfaces
{
    public interface ISmartPhone
    {
        void Ligar();
        void ReceberLigacao();

        void InstalarAplicativo(string nomeApp);
    }
}