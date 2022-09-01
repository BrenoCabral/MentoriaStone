using Livraria;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var listaDeItenEmprestados = new ItensEmprestados();
var listaDeItensRarosEmprestados = new ItensRarosEmprestados();

var bibliotecaDeGibi = new Biblioteca(listaDeItenEmprestados);

var publicacao = bibliotecaDeGibi.PegarPublicacao("asd");
var publicacao2 = bibliotecaDeGibi.PegarPublicacao("adf");

var bibliotecaFiccao = new Biblioteca(listaDeItenEmprestados);
var publicacao3 = bibliotecaFiccao.PegarPublicacao("qwe");

var bibliotecaDeDocumentosImportantes = new Biblioteca(listaDeItensRarosEmprestados);

