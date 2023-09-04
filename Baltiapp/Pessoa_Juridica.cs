namespace SistemaBalti
{
    class Pessoa_Juridica : Clientes
    {
        protected string cnpj;
        protected string ie;

        public void Set_Cnpj(string n)
        {
            this.cnpj = n;
        }
        public string Get_Cnpj()
        {
            return this.cnpj;
        }

        public void Set_Ie(string n)
        {
            this.ie = n;
        }
        public string Get_Ie()
        {
            return this.ie;
        }

        public override void Set_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.valor + this.valor_imposto;
        }
    }
    
}