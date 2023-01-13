namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        /// <summary>
        /// Instala um app no smartphone
        /// </summary>
        /// <param name="nomeApp">Nome do aplicativo</param>
        /// <param name="extensao">Extensão do aplicativo. ".apk" para Android / ".ipa" para IOS</param>
        public abstract void InstalarAplicativo(string nomeApp, string extensao);
    }
}