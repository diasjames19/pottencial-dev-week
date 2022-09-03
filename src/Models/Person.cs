using System.Collections.Generic;
namespace src.Models;

public class Person
{

    public Person()
    {
        this.nome = "templete";
        this.idade = 0;
        this.cpf = "";
        this.ativo = false;
        this.contratosAtivos = new List<Contract>();
    }
    public Person(string nome, int idade, string cpf){
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.contratosAtivos = new List<Contract>();
    }
    public int id { get; set; }
    public string nome{ get; set;}
    public int idade{ get; set;}
    public string? cpf { get; set; }    
    public Boolean ativo{ get; set;}

    public List<Contract> contratosAtivos{ get; set;}
    
    
}