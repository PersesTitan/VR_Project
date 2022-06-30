#include <MPU6050_tockn.h>
#include <Wire.h>

MPU6050 mpu(Wire);

float bx = 0.0;
float by = 0.0;
float bz = 0.0;

void setup() {
  Serial.begin(19200);
  Wire.begin();
  mpu.begin();

  //평균값 구하는 코드, 초기값 구하면 초기값 입력
  //mpu.setGyroOffsets(-0.57,1.31,1.49);
  mpu.setGyroOffsets(true);

  //초기값 구하기
  bx = mpu.getAngleX();
  by = mpu.getAngleY();
  bz = mpu.getAngleZ();

  pinMode(8,INPUT_PULLUP);
}

void loop() {
  mpu.update();

  if(analogRead(A0)>=800)Serial.print(1);
  else if(analogRead(A0)<=300)Serial.print(-1);
  else Serial.print(0);
  Serial.print(" ");

  if(analogRead(A1)>=800)Serial.print(1);
  else if(analogRead(A1)<=300)Serial.print(-1);
  else Serial.print(0);
  Serial.print(" ");

  //조이스틱 버튼
  Serial.print(digitalRead(8));
  Serial.print(" ");

  //현재 각속도 불러오기
  float ax = mpu.getAngleX();
  float ay = mpu.getAngleY();
  float az = mpu.getAngleZ();

  //50ms 전 각속도 - 현재 각속도
  float x = ax - bx;
  float y = ay - by;
  float z = az - bz;

  //이전 각속도 초기화
  bx = mpu.getAngleX();
  by = mpu.getAngleY();
  bz = mpu.getAngleZ();

  Serial.print(x);
  Serial.print(" ");
  Serial.print(y);
  Serial.print(" ");
  Serial.print(z);
  Serial.println();

  delay(50);
}