#include "Libs.h"

class ModoColherDados {
long int tempoUltimoPrint=millis();
#define intervaloPrint 50
  private:
long int contaLoops=0;
    
    
    void printCabecalho(){
      Serial.println("N T EM1 EM2 EM3 EM4 EM5 EM6 EM7 EM8 EM9 EM10 EM11 EM12 CM1 CM2 CM3 CM4 CM5 CM6 CM7 CM8 CM9 CM10 CM11 CM12 GyX GyY GyZ AcX AcY AcZ Tmp HCSR X Y Z");
    }
    void print() {
      if((millis()-tempoUltimoPrint)>intervaloPrint){
      Serial.print("{");
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
      for (int i = 0; i < 8; i++) {
        Serial.print(sensores[i]);
        Serial.print(" ");
      }

      for (int i = 0; i < 3; i++) {
        Serial.print(angulo[i]);
        Serial.print(" ");
      }
      Serial.println("}");
      tempoUltimoPrint=millis();
      }
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
      lerSerial();
    }
    void Setup(){
      this->printCabecalho();
      lerSensores();
     // Serial.println("Fazendo a primeira leitura");
      delay(5000);
    }
    
};

class ModoControleNeural {
long int tempoUltimoPrint=millis();
#define intervaloPrint 50
  private:
long int contaLoops=0;
    
    
    void printCabecalho(){
      Serial.println("N T EM1 EM2 EM3 EM4 EM5 EM6 EM7 EM8 EM9 EM10 EM11 EM12 CM1 CM2 CM3 CM4 CM5 CM6 CM7 CM8 CM9 CM10 CM11 CM12 GyX GyY GyZ AcX AcY AcZ Tmp HCSR X Y Z");
    }
    void print() {
      if((millis()-tempoUltimoPrint)>intervaloPrint){
      Serial.print("{");
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
      for (int i = 0; i < 8; i++) {
        Serial.print(sensores[i]);
        Serial.print(" ");
      }

      for (int i = 0; i < 3; i++) {
        Serial.print(angulo[i]);
        Serial.print(" ");
      }
      Serial.println("}");
      tempoUltimoPrint=millis();
      }
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
      String mensagem=lerSerial();
      
      obterComandos(mensagem);
      if(debug){
        Serial.println("Comandando servos");
      }
      comandarServos();
      this->print();
      this->contaLoops++;
      
    }
    void Setup(){
      this->printCabecalho();
      lerSensores();
     // Serial.println("Fazendo a primeira leitura");
      delay(5000);
    }
    
};

ModoColherDados modoColherDados;
ModoControleNeural modoControleNeural;

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
if (!mpu.begin()) {
    Serial.println("Failed to find MPU6050 chip");
}
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
   

mpu.setAccelerometerRange(MPU6050_RANGE_8_G);
  Serial.print("Accelerometer range set to: ");
  switch (mpu.getAccelerometerRange()) {
  case MPU6050_RANGE_2_G:
    Serial.println("+-2G");
    break;
  case MPU6050_RANGE_4_G:
    Serial.println("+-4G");
    break;
  case MPU6050_RANGE_8_G:
    Serial.println("+-8G");
    break;
  case MPU6050_RANGE_16_G:
    Serial.println("+-16G");
    break;
  }
  mpu.setGyroRange(MPU6050_RANGE_500_DEG);
  Serial.print("Gyro range set to: ");
  switch (mpu.getGyroRange()) {
  case MPU6050_RANGE_250_DEG:
    Serial.println("+- 250 deg/s");
    break;
  case MPU6050_RANGE_500_DEG:
    Serial.println("+- 500 deg/s");
    break;
  case MPU6050_RANGE_1000_DEG:
    Serial.println("+- 1000 deg/s");
    break;
  case MPU6050_RANGE_2000_DEG:
    Serial.println("+- 2000 deg/s");
    break;
  }

  mpu.setFilterBandwidth(MPU6050_BAND_21_HZ);
  Serial.print("Filter bandwidth set to: ");
  switch (mpu.getFilterBandwidth()) {
  case MPU6050_BAND_260_HZ:
    Serial.println("260 Hz");
    break;
  case MPU6050_BAND_184_HZ:
    Serial.println("184 Hz");
    break;
  case MPU6050_BAND_94_HZ:
    Serial.println("94 Hz");
    break;
  case MPU6050_BAND_44_HZ:
    Serial.println("44 Hz");
    break;
  case MPU6050_BAND_21_HZ:
    Serial.println("21 Hz");
    break;
  case MPU6050_BAND_10_HZ:
    Serial.println("10 Hz");
    break;
  case MPU6050_BAND_5_HZ:
    Serial.println("5 Hz");
    break;
  }

  Serial.println("");
 // delay(100);
  Serial.println("Robo Inteligente Iniciado");
  mpu6050.begin();
  //mpu6050.calcGyroOffsets(true);
  //modoColherDados.Setup();
  modoControleNeural.Setup();
}

void loop() {
  // put your main code here, to run repeatedly:
  //Serial.println("Loop");
 // modoColherDados.Loop();
  
  modoControleNeural.Loop();

}
