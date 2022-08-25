#include "Libs.h"




class ModoColherDados {

  private:
long int contaLoops=0;
    
    
    void printCabecalho(){
      Serial.println("EM1 EM2 EM3 EM4 EM5 EM6 EM7 EM8 EM9 EM10 EM11 EM12 CM1 CM2 CM3 CM4 CM5 CM6 CM7 CM8 CM9 CM10 CM11 CM12 AcX AcY AcZ Tmp GyX GyY GyZ HCSR ");
    }
    void print() {
      Serial.print(this->contaLoops);
      Serial.print(" ");
      Serial.print(tempo);
      Serial.print(" ");
      for (int i = 0; i < 12; i++) {
        Serial.print(estadosMotores[i]);
        Serial.print(" ");
      }
      for (int i = 0; i < 12; i++) {
        Serial.print(comandosMotores[i]);
        Serial.print(" ");
      }
      for (int i = 0; i < 7; i++) {
        Serial.print(sensores[i]);
        Serial.print(" ");
      }
      Serial.println();
    }

    
  public:
    void Loop() {
      #define debug false

      if(debug){
        Serial.println("Lendo sensores");
      }
      lerSensores();
      if(debug){
        Serial.println("gerando comandos");
      }
      gerarComandosAleatorios();
      if(debug){
        Serial.println("Comandando servos");
      }
      comandarServos();
      this->print();
      this->contaLoops++;
    }
    void Setup(){
      this->printCabecalho();
    }
    
};



ModoColherDados modoColherDados;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  //Inicializa o MPU-6050

Wire.begin();
Wire.beginTransmission(MPU);
Wire.write(0x6B);

//Inicializa o MPU-6050
Wire.write(0);
Wire.endTransmission(true);

   servos[0].attach(2);  // attaches the servo on pin

   servos[1].attach(3);  // attaches the servo on pin 

   servos[2].attach(4);  // attaches the servo on pin 

   servos[3].attach(5);  // attaches the servo on pin 

   servos[4].attach(6);  // attaches the servo on pin 

   servos[5].attach(7);  // attaches the servo on pin

   servos[6].attach(8);  // attaches the servo on pin

   servos[7].attach(9);  // attaches the servo on pin
;
   servos[8].attach(10);  // attaches the servo on pin 

   servos[9].attach(11);  // attaches the servo on pin 

   servos[10].attach(12);  // attaches the servo on pin 

   servos[11].attach(13);  // attaches the servo on pin 
   


  Serial.println("Robo Inteligente Iniciado");
  modoColherDados.Setup();
}

void loop() {
  // put your main code here, to run repeatedly:
  //Serial.println("Loop");
  modoColherDados.Loop();
}
