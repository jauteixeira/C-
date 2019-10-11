namespace ByteBank
{
    public class Cliente
    {
        private string _cpf;
        private string _nome;
        private string _email;
        private string _senha;

        public string Nome
        {
            get {return _nome;}
        }

        public string Email
        {
            get {return _email;}
        }

        public string Cpf
        {
            get {return _cpf;}
        }
        public Cliente(string Nome, string Cpf, string Email)
        {
            this._nome = Nome;
            this._cpf = Cpf;
            this._email = Email;
        }

        public bool TrocaSenha(string senha)
        {
            if((senha.Length > 6) && (senha.Length < 16))
            {
                this._senha = senha;
                return true;
            } else 
            
            {
                return false;
            }
        }
    }
}