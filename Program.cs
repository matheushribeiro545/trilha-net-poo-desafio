using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(
                                numero: "19993202266", 
                                modelo: "C6", 
                                imei: "991248423894", 
                                memoria: 128
                            );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(nomeApp: "WhatsApp", extensao: ".apk");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(
                                numero: "19974215674",
                                modelo: "13 Pro Max",
                                imei: "345073091232",
                                memoria: 512
                            );
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "Linkedin", extensao: ".ipa");