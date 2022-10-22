namespace DesafioPOO.Models
{
    public abstract class Smartphone
    { 

        // ATRIBUTO
        public string Numero { get; set; }
        private string Modelo{get;set;}

        private string IMEI{get;set;}

        private int Memoria {get;set;}
        

        public Smartphone(string numero, string modelo, string iMEI, int memoria )
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
            
        }
        

        // MÉTODOS
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void Configuracao(){

             Console.WriteLine($"NUMERO: {Numero}, MODELO: {Modelo},IMEI: {IMEI}, MEMORIA: {Memoria}");

        }

       


        public abstract void InstalarAplicativo(string nomeApp);
    }
}