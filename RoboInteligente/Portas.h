//Portas e variaveis globais

#define pino_trigger 22
#define pino_echo 24
#include <Adafruit_MPU6050.h>
Adafruit_MPU6050 mpu;
Ultrasonic ultrasonic(pino_trigger, pino_echo);
Servo servos[12];

long int tempo = 0;


int estadosMotores[12] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; //Estados atuais dos motores
int comandosMotores[12] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; //Comandos atuais para os motores
float sensores[8] = {0, 0, 0, 0, 0, 0,0,0 }; //Medicoes dos sensores{EIX,EIY,EIZ,EAX,EAY,EAZ,ED}
float angulo[3]={0,0,0};
float posicao[3]={0,0,0};
int delayMotores=0 ; //Comandos atuais para os motores
//MÉTODO RESPONSÁVEL POR CALCULAR A DISTÂNCIA USANDO O SENSOR ULTRASSONICO HCSR-04
void hcsr04() {

  long microsec = ultrasonic.timing();
  sensores[7] = ultrasonic.convert(microsec, Ultrasonic::CM);

}
void lerServos(){
  for(int i=0;i<12;i++){
    estadosMotores[i]=servos[i].read();
  }
}
void comandarServos(){
  
  for(int i=0;i<12;i++){
    
    servos[i].write(comandosMotores[i]);
  }
  delay(delayMotores);
}
const int MPU=0x68;  
void lerGiroscopioAcelerometro(){
  //Endereco I2C do MPU6050

 // int AcX,AcY,AcZ,Tmp,GyX,GyY,GyZ;
  Wire.beginTransmission(MPU);
  Wire.write(0x3B);  // starting with register 0x3B (ACCEL_XOUT_H)
  Wire.endTransmission(false);
  //Solicita os dados do sensor
  Wire.requestFrom(MPU,14,true);  
  //Armazena o valor dos sensores nas variaveis correspondentes
//  AcX=Wire.read()<<8|Wire.read();  //0x3B (ACCEL_XOUT_H) & 0x3C (ACCEL_XOUT_L)     
//  AcY=Wire.read()<<8|Wire.read();  //0x3D (ACCEL_YOUT_H) & 0x3E (ACCEL_YOUT_L)
//  AcZ=Wire.read()<<8|Wire.read();  //0x3F (ACCEL_ZOUT_H) & 0x40 (ACCEL_ZOUT_L)
//  Tmp=Wire.read()<<8|Wire.read();  //0x41 (TEMP_OUT_H) & 0x42 (TEMP_OUT_L)
//  GyX=Wire.read()<<8|Wire.read();  //0x43 (GYRO_XOUT_H) & 0x44 (GYRO_XOUT_L)
//  GyY=Wire.read()<<8|Wire.read();  //0x45 (GYRO_YOUT_H) & 0x46 (GYRO_YOUT_L)
//  GyZ=Wire.read()<<8|Wire.read();  //0x47 (GYRO_ZOUT_H) & 0x48 (GYRO_ZOUT_L)
   

//Inicio leitura

  /* Get new sensor events with the readings */
  sensors_event_t a, g, temp;
  mpu.getEvent(&a, &g, &temp);

//  /* Print out the values */
// // Serial.print("Acceleration X: ");
//  Serial.print(a.acceleration.x);
// // Serial.print(", Y: ");
//  Serial.print(a.acceleration.y);
////  Serial.print(", Z: ");
//  Serial.print(a.acceleration.z);
// // Serial.println(" m/s^2");

//  Serial.print("Rotation X: ");
//  Serial.print(g.gyro.x);
//  Serial.print(", Y: ");
//  Serial.print(g.gyro.y);
//  Serial.print(", Z: ");
//  Serial.print(g.gyro.z);
//  Serial.println(" rad/s");
//
//  Serial.print("Temperature: ");
//  Serial.print(temp.temperature);
//  Serial.println(" degC");
//
//  Serial.println("");
//  delay(500);
//fim



float pi=3.14159265359;
float radToDeg=180.00000/pi;



  sensores[0]=(g.gyro.x+0.151155351-(6.000/radToDeg))*radToDeg;
  sensores[1]=(g.gyro.y+(-0.014556962))*radToDeg;
  sensores[2]=(g.gyro.z+(-0.020506329))*radToDeg;
  sensores[3]=(a.acceleration.x)+0.197531646;
  sensores[4]=(a.acceleration.y)+1.222341772;
  sensores[5]=(a.acceleration.z)+10.36518987;
  sensores[6]=temp.temperature;
 
  //Aguarda 300 ms e reinicia o processo
 // delay(300);
}
float tempoInicial=0;
void obterAngulos(){
//  float tempoAtual=float(millis())/1000.00;
//
//  float tempoCorrido=tempoAtual-tempoInicial;
//  angulo[0]+=sensores[0]*tempoCorrido;
//  angulo[1]+=sensores[1]*tempoCorrido;
//  angulo[2]+=sensores[2]*tempoCorrido;
//  
//
//  posicao[0]+=sensores[3]*tempoCorrido;
//  posicao[1]+=sensores[4]*tempoCorrido;
//  posicao[2]+=sensores[5]*tempoCorrido;
//  tempoInicial=tempoAtual;
}
void lerSensores() {
  #define debug false


  tempo = millis();
    if(debug){
    Serial.println("Lendo ultrassonico");
  }
  hcsr04();
      if(debug){
    Serial.println("Lendo servos");
  }
  lerServos();

        if(debug){
    Serial.println("Lendo giroscopio e acelerometro");
  }
  lerGiroscopioAcelerometro();
  obterAngulos();
}
void gerarComandosAleatorios() {
  int minAng=-20;//Menor angulo de variacao
  int maxAng=20;//Maior angulo de variacao
  int menorTempo=1;
  int maiorTempo=200;

int posicaoEstavel[12]={90,90,90,90,90,90,90,90,90,90,90,90};
 for(int i=0;i<12;i++){
    comandosMotores[i]=posicaoEstavel[i]+random(minAng, maxAng);
    //construir função que gera delay
    
  }

  delayMotores=random(menorTempo, maiorTempo);
}
