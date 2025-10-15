extends State

class_name PlayerController

@export var Player: CharacterBody2D
@export var AnimationSprite: AnimatedSprite2D
@export var AccelerationCurve = Curve
@export var moveSpeed := 200
@export var AccelValue := 5
@export var MoveSpeedCap := 300
@export var BrakeThreshold := 50
var emergencyStopToggle = false
var moveDirection : Vector2
var friction = 0.95

func Enter():
	AccelerationCurve.max_domain = MoveSpeedCap
	print(AccelerationCurve.max_domain)

func PhysicsUpdate(delta: float):
	
	if Input.is_action_pressed("Right"):
		print("Sending Right Signal")
		moveDirection = Vector2(1,0)
	if Input.is_action_pressed("Left"):
		print("Sending Left Signal")
		moveDirection = Vector2(-1,0)
	if Input.is_action_pressed("Jump"):
		print("Sending Jump Signal")
		Transition.emit(self, "Jump")
	
	if Player:
		
		
		if Player.velocity.x >= BrakeThreshold:
			emergencyStopToggle = true
			Player.velocity.x = Player.velocity.x * friction
		if ((abs(Player.velocity.x) < BrakeThreshold) && (emergencyStopToggle == true)):
			print("Emergency Halt")
			Player.velocity.x = 0
			moveDirection = Vector2.ZERO
			AnimationSprite.play("Idle")
			emergencyStopToggle = false
