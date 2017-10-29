// File Name:   LED_fade
// Creator:     Sebastian Humbel
// Change Date: 29.Oct.2017

// Description:
// ------------------------------
// Change the color of the LEDs depending on the input of the serial.
// The Arduino receves for every color a value between 0 and 255,
// which stands for the brightness.
// The fourd input is the delay. That defines how fast the LEDs change
// from one color to the next.
// ------------------------------


// Define Output Pins
#define PinLedR 10  
#define PinLedG 9
#define PinLedB 6
#define PinLedW 5

// Initialize Output pins and Serial
void setup() {
  pinMode(PinLedR, OUTPUT);
  pinMode(PinLedG, OUTPUT);
  pinMode(PinLedB, OUTPUT);
  pinMode(PinLedW, OUTPUT);
  
  Serial.begin(9600);
}

int ledR = 0;
int ledG = 0;
int ledB = 0;
int ledW = 0;

// Buffer variable
int input;
int R = 0;
int G = 0;
int B = 0;
int W = 0;
int delaytime = 0;

void initialize()
{
  analogWrite(PinLedR, ledR);
  analogWrite(PinLedG, ledG);
  analogWrite(PinLedB, ledB);
  analogWrite(PinLedW, ledW);
}

// Wait for the Serial input and save it in the buffer.
// After that change the output with "dimmer()"
void loop() {
  if(Serial.available() > 0)
  {
    R = Serial.read();
    G = Serial.read();
    B = Serial.read();
    W = Serial.read();
    delaytime = Serial.read();
  }
  dimmer(R,G,B,W,delaytime);
}

// change the color of the output.
void dimmer(int _endvalueR, int _endvalueG, int _endvalueB, int _endvalueW, int _delaytime)
{    
  int endvalueR = _endvalueR;
  int endvalueG = _endvalueG;
  int endvalueB = _endvalueB;
  int endvalueW = _endvalueW;
  int delaytime = _delaytime;
  bool finished = false;
  
    while(finished != true)
    {
      if(Serial.available() > 0)
      {
        break;
      }
      // Red
      if(endvalueR < ledR )
      {
        ledR--;      
      }
      else if(endvalueR > ledR)
      {
        ledR++;
      }

      // Green
      if(ledG > endvalueG)
      {
        ledG--;      
      }
      else if(ledG < endvalueG)
      {
        ledG++;
      }

      // Blue
      if(ledB > endvalueB)
      {
        ledB--;      
      }
      else if(ledB < endvalueB)
      {
        ledB++;
      }

      // White
      if(ledW > endvalueW)
      {
        ledW--;      
      }
      else if(ledW < endvalueW)
      {
        ledW++;
      }
          
      initialize();
      delay(delaytime);

      if(ledR == endvalueR)
        if(ledG == endvalueG)
          if(ledB == endvalueB)
            if(ledW == endvalueW)
              finished = true;
    }
}



