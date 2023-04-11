// See https://aka.ms/new-console-template for more information
using BlockCraft;

Console.WriteLine("Hello, World!");

arma pico = new arma("Pico de diamante",0.1);
arma espada = new arma("Espada de oro", 0.3);
personaje steve = new personaje("Steve",pico);
enemigo creeper = new enemigo("Creeper");


//
//steve.atacar(creeper);

Console.WriteLine("daño con pico "+pico.getDanio());
Console.WriteLine("batalla: "+steve.atacar(creeper));
creeper.calcularDanio(steve.atacar(creeper));
Console.WriteLine("la vida del creeper: " + creeper.getVida());

Console.WriteLine("\n");
Console.WriteLine("Segundo batalla");
Console.WriteLine("\n");

steve.cambiarArma(espada);
Console.WriteLine("daño con espada " + espada.getDanio());
creeper.calcularDanio(steve.atacar(creeper));
//creeper.calcularDanio(100);
Console.WriteLine("daño con espada " + steve.atacar(creeper));
Console.WriteLine("la vida del creeper: " + creeper.getVida());


Console.WriteLine(creeper.status());
