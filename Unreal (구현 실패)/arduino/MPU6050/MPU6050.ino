#include "MPU6050.h"

MPU6050 mpu6050(Wire);
long timer = 0;

void setup() {
  
  Serial.begin(115200);
  Wire.begin();
  mpu6050.begin();
  mpu6050.calcGyroOffsets(true);
}

void loop() {
  // put your main code here, to run repeatedly:

}
