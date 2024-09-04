namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
         public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = Imei;
            Memoria = memoria;
            // Complete: Passar os parâmetros do construtor para as propriedades
        }

        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string  Imei { get; set; }
        protected int Memoria { get; set; }
        // Complete: Implementar as propriedades faltantes de acordo com o diagrama

    
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