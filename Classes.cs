using System;
using System.Collections;
using System.Collections.Generic;

namespace Classes{

public class Cliente {

    public int idCliente;
	public String nome;
	public String dataNasc;
	public String cpf;
	public int diaDev;
	public int filmesLocados;

    // public List<Locacao> locacoes = new ArrayList<Locacao>();

    public Cliente(int idCliente, String nome, String dataNasc, String cpf, int diaDev) {
		
		this.idCliente = idCliente;
		this.nome = nome;
		this.dataNasc = dataNasc;
		this.cpf = cpf;
		this.diaDev = diaDev;
		this.filmesLocados = 0;
	}

    // // Adição de Locações 
	// void adicionarLocacao(Locacao locacao){
    //     this.locacoes.add(locacao);
    // }



    // //Lista de Locações
    // public int locacoes(){
	// 	public int qtd = 0;
	// 	for(Locacao locacao :this.locacoes){
	// 		for(Filme filme: locacao.filmes){
	// 			qtd++;
	// 		}
	// 	}
	// 	return qtd;
	// }

}
}

public class Filme {
    // Atributos
    public int idFilme;
    public String titulo;
    public String dataLanc;
    public String sinopse;
    public Double valorLoc;
    public int estoque;
    public int estAtual;
    public int locado; 
    
    // Construtor
    public Filme (int idFilme, String titulo, String dataLanc, String sinopse, Double valorLoc, int estoque) {
        this.idFilme = idFilme;
        this.titulo = titulo;
        this.dataLanc = dataLanc;
        this.sinopse = sinopse;
        this.valorLoc = valorLoc;
        this.estoque = estoque;
        this.locado = 0;        
    }
}