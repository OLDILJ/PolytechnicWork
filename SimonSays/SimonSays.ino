const int buttonPin = 3;
const int buttonPin2 = 4;
const int buttonPin3 = 5;
const int buttonPin4 = 6;  
const int ledPin = 8;    
const int ledPin2 = 9;
const int ledPin3 = 11;
const int ledPin4 = 12;
const int LedArray[] = { 8, 9, 11, 12};
int SequenceArray[10] = {0,0,0,0,0,0,0,0,0,0};
int buttonState = 0; 
int buttonState2 = 0;
int buttonState3 = 0;
int buttonState4 = 0;
volatile int ButtonSelect = 0;
int PInput = 5;
void setup() {
  Serial.begin(9600);
  
  pinMode(ledPin, OUTPUT);
  pinMode(ledPin2, OUTPUT);
  pinMode(ledPin3, OUTPUT);
  pinMode(ledPin4, OUTPUT);
  digitalWrite(ledPin, HIGH); //LED PIN = RED
  digitalWrite(ledPin2, HIGH); //LED PIN2 = BLUE
  digitalWrite(ledPin3, HIGH); //LED PIN3 = YELLOW
  digitalWrite(ledPin4, HIGH); //LED PIN4 = GREEN

 pinMode(buttonPin, INPUT);
 pinMode(buttonPin2, INPUT);
 pinMode(buttonPin3, INPUT);
 pinMode(buttonPin4, INPUT);
 randomSeed(analogRead(A0));

}

void loop() {
  
  
  
  for (int turn = 0; turn <= 10; turn++)
  {
    int RandVal = random(0, 4);
    SequenceArray[turn] = RandVal;
    gameLogic(SequenceArray, turn);
  }
}

int gameLogic(int SeqArray[],  int InitTurn)
{
  Serial.print("Current Array Position Value ");
  Serial.println(SeqArray[InitTurn]);
  Serial.print("Currnet Turn Number ");
  Serial.println(InitTurn);
  int RandVal = random(0, 4);
  SequenceArray[InitTurn] = RandVal;
  if (InitTurn == 2)
  {
    for (int WinFlash = 0; WinFlash <= 8; WinFlash++)
      {
        digitalWrite(ledPin, LOW);
        digitalWrite(ledPin2, LOW);
        digitalWrite(ledPin3, LOW);
        digitalWrite(ledPin4, LOW);
        delay(100);

        ResetLED();
        delay(100);
      }
    InitTurn = 0;
    int RandVal = random(0, 4);
  }
  CurTurnLoop(SeqArray[InitTurn],InitTurn,SeqArray);
    
}
void ResetLED()
{
  digitalWrite(ledPin, HIGH); //LED PIN = RED
  digitalWrite(ledPin2, HIGH); //LED PIN2 = BLUE
  digitalWrite(ledPin3, HIGH); //LED PIN3 = YELLOW
  digitalWrite(ledPin4, HIGH); //LED PIN4 = GREEN
}
int PlayerInput()
{
  while (buttonState == LOW || buttonState2 == LOW || buttonState3 == LOW || buttonState4 == LOW) {
    digitalWrite(ledPin, HIGH);
    digitalWrite(ledPin2, HIGH);
    digitalWrite(ledPin3, HIGH);
    digitalWrite(ledPin4, HIGH);
    buttonState = digitalRead(buttonPin);
    buttonState2 = digitalRead(buttonPin2);
    buttonState3 = digitalRead(buttonPin3);
    buttonState4 = digitalRead(buttonPin4);
    //Serial.println("Waiting For Player");
      if (buttonState == HIGH) {
      // turn LED on:
      digitalWrite(ledPin, LOW);
      PInput = 2;
      delay(100);
      return PInput;
    } else if (buttonState2 == HIGH) {
      // turn LED off:
      digitalWrite(ledPin2, LOW);
      PInput = 3;
      delay(100);
      return PInput;
    } else if (buttonState3 == HIGH) {
      digitalWrite(ledPin3, LOW);
      PInput = 1;
      delay(100);
      return PInput;
    } else if (buttonState4 == HIGH) {
      // turn LED off:
      digitalWrite(ledPin4, LOW);
      PInput = 0;
      delay(100);
      return PInput;
    }
  } 
}
int CurTurnLoop(int CurrentSequenceNum, int CurTurn, int SeqArray[])
{
  for (int i = 0; i <= CurTurn; i++)
  {
    ResetLED();
    delay(500);

    switch (SeqArray[i])
    {
      case 0:
        digitalWrite(ledPin4, LOW); // GREEN
        Serial.println("GREEN ON");
        break;

      case 1:
        digitalWrite(ledPin3, LOW); // YELLOW
        Serial.println("YELLOW ON");
        break;

      case 2:
        digitalWrite(ledPin, LOW); // RED
        Serial.println("RED ON");
        break;

      case 3:
        digitalWrite(ledPin2, LOW); // BLUE
        Serial.println("BLUE ON");
        break;
    }

    delay(1000);
    ResetLED();
  }

 
  for (int i = 0; i <= CurTurn; i++)
  {
    int PlayerAnswer = PlayerInput();

    Serial.print("Player Input: ");
    Serial.println(PlayerAnswer);

    Serial.print("Correct Answer: ");
    Serial.println(SeqArray[i]);

    if (PlayerAnswer != SeqArray[i])
    {
      Serial.println("fail");
      
      // Flash all leds
      for (int FailFlash = 0; FailFlash <= 4; FailFlash++)
      {
        digitalWrite(ledPin, LOW);
        digitalWrite(ledPin2, LOW);
        digitalWrite(ledPin3, LOW);
        digitalWrite(ledPin4, LOW);
        delay(200);

        ResetLED();
        delay(200);
      }

      return 0;
    }

    Serial.println("correct");
    ResetLED();
    delay(200);
  }

  Serial.println("next round");
  gameLogic(SeqArray, CurTurn + 1);

  return 0;
}



  /*
  switch (SeqArray[CurTurn])
  {
    case 0:
      digitalWrite(ledPin4, LOW); // GREEN
      Serial.println("GREEN ON");
      delay(1000);
      break;
    case 1:
      digitalWrite(ledPin3, LOW); // YELLOW
      Serial.println("YELLOW ON");
      delay(1000);
      break;
    case 2:
      digitalWrite(ledPin, LOW); // RED
      Serial.println("RED ON");
      delay(1000);
      break;
    case 3:
      digitalWrite(ledPin2, LOW); // BLUE
      Serial.println("BLUE ON");
      delay(1000);
      break;
    default:
      break;
  }
  */


