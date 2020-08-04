namespace ByteBank
{
    public class ContaCorrente
    {
        private Cliente titular = new Cliente();
        private int agencia;
        private int numero;
        private double saldo;

        public ContaCorrente(string titular, int agencia, int numero)
        {
            this.titular = titular;
            this.agencia = agencia;
            this.numero = numero;
        }

        public string getTitular()
        {
            return titular;
        }

        public int getAgencia()
        {
            return agencia;
        }
    }
}