extends State

class_name PlayerController

@export var Player: CharacterBody2D
@export var AnimationSprite: AnimatedSprite2D
@export var AccelerationCurve:  Curve
@export var AccelValue := 5
@export var MoveSpeedCap := 300
@export var BrakeThreshold := 50
var emergencyStopToggle = false
var moveDirection : Vector2
var friction = 0.9
var NoInput = false

@warning_ignore("unused_parameter")
func PhysicsUpdate(delta: float):
	
	if Input.is_action_pressed("Right"):
		#print("Sending Right Signal")
		moveDirection = Vector2(1,0)
	if Input.is_action_pressed("Left"):
		#print("Sending Left Signal")
		moveDirection = Vector2(-1,0)
	if Input.is_action_pressed("Jump"):
		#print("Sending Jump Signal")
		Transition.emit(self, "Jump")
	if (Input.is_action_pressed("Left") or Input.is_action_pressed("Right")) == false:
		NoInput = true
	else: NoInput = false
	
	if Player:
		if abs(Player.velocity.x) > 1:
			AnimationSprite.play("Run")

		### Movement Code
		@warning_ignore("narrowing_conversion")
		AccelValue = AccelerationCurve.sample(MoveSpeedCap/abs(Player.velocity.x))
		#print("Math Test ", (MoveSpeedCap/abs(Player.velocity.x)))
		print("Accel Value = ", AccelValue)
		Player.velocity.x = Player.velocity.x + AccelValue * moveDirection.x
		print("Player Velocity ", Player.velocity.x)
		@warning_ignore("integer_division")
		if abs(Player.velocity.x) > BrakeThreshold + (BrakeThreshold/5):
			#print("Enable Friction")
			emergencyStopToggle = true
			Player.velocity.x = Player.velocity.x * friction
		if NoInput:
			#print("Enable Friction & Accel Removal")
			emergencyStopToggle = true
			@warning_ignore("narrowing_conversion")
			AccelValue = AccelValue * -friction
			Player.velocity.x = Player.velocity.x + AccelValue * moveDirection.x
		if abs(Player.velocity.x) > MoveSpeedCap:
			Player.velocity.x = MoveSpeedCap * moveDirection.x
		if ((abs(Player.velocity.x) < BrakeThreshold) && (emergencyStopToggle == true)):
			#print("Emergency Halt")
			Player.velocity.x = 0
			moveDirection = Vector2.ZERO
			emergencyStopToggle = false
			if AnimationSprite.get_animation() != "Idle" && Player.is_on_floor():
				print("Swapping To Idle Anim")
				AnimationSprite.play("Idle")

			
			
