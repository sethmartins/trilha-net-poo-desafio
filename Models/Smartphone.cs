using DesafioPOO.Interfaces;

namespace DesafioPOO.Models
{
    public abstract class Smartphone : ISmartPhone
    {
        public string Numero { get; set; }       
        private int memoria;
        private string modelo;
        private string imei;
        public Smartphone(string numero, int memoria, string modelo, string imei)
        {
            Numero = numero;
      
            this.memoria = memoria;
            this.modelo = modelo;
            this.imei = imei;

        }
        /// <summary>
        /// Fazer ligações para outros aparelhos
        /// </summary>
        public void Ligar()
        {
            Console.WriteLine($"Aparelho {modelo} fazendo ligação");
        }
        /// <summary>
        /// Recebendo ligações dev outros aparelhos
        /// </summary>
        public void ReceberLigacao()
        {
            Console.WriteLine($"Aparelho {modelo} recebendo ligação");
        }
        /// <summary>
        /// Instala o aplicativo no Smartphone
        /// </summary>
        /// <param name="nomeApp">Nome do Aplicativo a ser instaldo</param>
        public abstract void InstalarAplicativo(string nomeApp);
    }
}