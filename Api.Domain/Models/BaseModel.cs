using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
   public class BaseModel
    {
       

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _telefone;

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }


        private char _sexo;

        public char Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }


        private string _cep;

        public string CEP
        {
            get { return _cep; }
            set { _cep = value; }
        }


        private int _numeroPredial;

        public int NumeroPredial
        {
            get { return _numeroPredial; }
            set { _numeroPredial = value; }
        }


        private DateTime _dataNascimento;

        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }


        private char _isolamentoSocial;

        public char IsolamentoSocial
        {
            get { return _isolamentoSocial; }
            set { _isolamentoSocial = value; }
        }


        private DateTime _inicioIsolamentoSocial;

        public DateTime InicioIsolamentoSocial
        {
            get { return _inicioIsolamentoSocial; }
            set { _inicioIsolamentoSocial = value == null ? DateTime.UtcNow : value; }
        }


        private DateTime _fimIsolamentoSocial;

        public DateTime FimIsolamentoSocial
        {
            get { return _fimIsolamentoSocial; }
            set { _fimIsolamentoSocial = value; }
        }


        private char _pessoaViva;

        public char PessoaViva
        {
            get { return _pessoaViva; }
            set { _pessoaViva = value; }
        }

             
    }
}
