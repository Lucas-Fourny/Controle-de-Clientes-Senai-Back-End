namespace SistemaBalti
{
    class Clientes
    {

        // Atributos
        protected string nome;
        protected string endereco;
        protected float valor;
        protected float valor_imposto;
        protected float total;


        // Metodos
        public void Set_Nome(string n)
        {
            this.nome = n;
        }
        public string Get_Nome()
        {
            return this.nome;
        }

        public void Set_Endereco(string n)
        {
            this.endereco = n;
        }
        public string Get_Endereco()
        {
            return this.endereco;
        }

        public void Set_Valor(float n)
        {
            this.valor = n;
        }
        public float Get_Valor()
        {
            return this.valor;
        }

        public virtual void Set_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10/100;
            this.total = this.valor + this.valor_imposto;
        }
        public float Get_Imposto()
        {
            return this.valor_imposto;
        }

        public float Get_Total()
        {
            return this.total;
        }
    }
}