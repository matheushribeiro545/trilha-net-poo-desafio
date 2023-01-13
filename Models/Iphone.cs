namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp, string extensao)
        {
            switch(extensao)
            { 
                case ".ipa":
                    Console.WriteLine($"Instalando {nomeApp}, aguarde...");
                    Thread.Sleep(3000);
                    Console.WriteLine($"{nomeApp} instalado com sucesso no {this.GetType().Name}!");
                    break;
                default:
                    Console.WriteLine($"Extensão não suportada no {this.GetType().Name}!");
                    break;
            }
        }
    }
}