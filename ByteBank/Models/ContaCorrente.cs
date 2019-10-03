namespace ByteBank.Models
{
    public class ContaCorrente
    {
        public string titular {get;set;}
        public int agencia {get;set;}
        public int numeroc {get;set;}
        public double saldo {get;set;}

        public ContaCorrente (int agencia, int numero, string titular){
            this.agencia = agencia;
            this.numeroc = numero;
            this.titular = titular;
            this.saldo = 0.0;
        }
    }
}