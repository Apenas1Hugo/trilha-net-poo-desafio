using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia(
            numero: "11999999999",
            modelo: "Nokia 3310",
            imei: "123456789012345",
            memoria: 64);

Iphone iphone = new Iphone(
            numero: "11999999999",
            modelo: "Iphone 14",
            imei: "123456789345",
            memoria: 32);
  
  
  
  
  nokia.InstalarAplicativo("WhatsApp");
  iphone.InstalarAplicativo("clash Royale");