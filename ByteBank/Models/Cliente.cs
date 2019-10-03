using System;

namespace ByteBank
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Cpf {get; set;}
        public string Senha;

        public Cliente(string nome, string email, string cpf){
            this.Nome = nome;
            this.Email = email;
            this.Cpf = cpf;
        }
        
        public bool TrocarSenha (string senha){
            if ((senha.Length > 6) && (senha.Length < 16)) {
                this.Senha = senha;
                return true;
            }
            else{
                return false;
            }
        }
    }
}