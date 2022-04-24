#include <MPU6050_tockn.h>
#include <Wire.h>

MPU6050 mpu6050(Wire);

void setup() {
  Serial.begin(19200);
  Wire.begin();
  mpu6050.begin();
  mpu6050.calcGyroOffsets(true);
  //초가값 구한뒤 교체하기
//    mpu6050.setGyroOffsets(0.75, 0.05, 0.05);
}

void loop() {
  mpu6050.update();  
  Serial.print(mpu6050.getAngleX());
  Serial.print(',');
  Serial.print(mpu6050.getAngleY());
  Serial.print(',');
  Serial.println(mpu6050.getAngleZ());
  delay(50);
}
