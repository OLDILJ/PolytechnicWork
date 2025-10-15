extends State

class_name PlayerJump

@export var Player: CharacterBody2D
@export var AnimationSprite: AnimatedSprite2D
@export var moveSpeed := 100
@export var JumpForce := 400
@export var AirStrafeSpeed := 5

func Enter():
	Player.velocity.y = -JumpForce

func PhysicsUpdate(delta: float):
	
	AnimationSprite.play("Jump")
	if AnimationSprite.frame == 4:
		AnimationSprite.play("Fall")
	if Input.is_action_pressed("Left"):
		Player.velocity.x = Player.velocity.x - AirStrafeSpeed
	if Input.is_action_pressed("Right"):
		Player.velocity.x = Player.velocity.x + AirStrafeSpeed
	if Player.is_on_floor():
		Transition.emit(self, "Default")
		
