// See https://aka.ms/new-console-template for more information
using BlockCraft;

Console.WriteLine("Hello, World!");

arma pico = new arma("Pico de diamante",10);
arma espada = new arma("Espada de oro", 30);
personaje steve = new personaje("Steve",pico);
enemigo creeper = new enemigo("Creeper");


//
//steve.atacar(creeper);

Console.WriteLine("daño con pico "+pico.getDanio());
Console.WriteLine()
creeper.calcularDanio(steve.atacar(creeper));
Console.WriteLine("la vida del creeper: " + creeper.getVida());



//steve.cambiarArma(espada);
//Console.WriteLine("daño con espada " + steve.atacar(creeper));
