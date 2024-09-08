using DesafioPOO.Interfaces;
using DesafioPOO.Models;
Console.WriteLine("Nokia: ");
ISmartPhone nokia = new Nokia("83998586321",4000,"3310","151651216511516561651615154610606");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tinder");

Console.WriteLine("Iphone: ");
ISmartPhone iphone = new Iphone("83988586321",16000,"16 pro max","7525528888282828282822822828288284141717");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tinder");
