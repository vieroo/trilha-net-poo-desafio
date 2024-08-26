namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo {get; set;}
        private int Memoria { get; set; }
        private string Imei { get; set; }

        public Smartphone(string numero, string modelo, int memoria, string imei)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Memoria = memoria;
            Imei = Imei;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}