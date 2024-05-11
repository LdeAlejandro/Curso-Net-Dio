using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_Net_2.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        
        //Exemplo de constructor
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

                //Exemplo de descontructor, a declaraição da variaveis é inversa e tem os parametros out
        public void Deconstruct( out string nome, out string sobrenome)
        {
            nome = Nome ;  
            sobrenome = Sobrenome ;
        }
        private string _nome;
        private int _idade;
        public string Nome 
        {   //se puede realizar de la siguiente manera si el return es de una linea.
            get => _nome.ToUpper();
            // {
            //     return _nome.ToUpper();
            // }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        } 

        public string Sobrenome { get; set; }

        public int Idade
        { 
            
            get => _idade;
            
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(" A idade não pode ser menor ou igual a zero");
                }
                _idade = value;

            }
        } 
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

    }
}