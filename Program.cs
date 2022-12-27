using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO

Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia(numero: "8000", modelo: "First Model", imei: "99999999999", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone(numero: "1000", modelo: "Second Model", imei: "99999999990", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");