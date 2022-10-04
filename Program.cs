using DesafioPOO.Models;

System.Console.WriteLine("SmartPhone Nokia");
Smartphone nokia = new Nokia(numero: "1111111", modelo: "Modelo 1", IMEI: "222222", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

System.Console.WriteLine("\n");

System.Console.WriteLine("SmartPhone Iphone");
Smartphone Iphone = new Iphone(numero: "1111111", modelo: "Modelo 1", IMEI: "222222", 64);
Iphone.Ligar();
Iphone.InstalarAplicativo("Instagram");