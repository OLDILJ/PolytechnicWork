extends State

class_name PlayerJump

@export var Player: CharacterBody2D
@export var AnimationSprite: AnimatedSprite2D

@export var moveSpeed := 100
@export var JumpForce := 400

var moveDirection : Vector2
var friction = 0.95
func Enter():
	Player.velocity.y = -300

func PhysicsUpdate(delta: float):
	
	AnimationSprite.play("Jump")
	if AnimationSprite.frame == 4:
		AnimationSprite.play("Fall")
	if Player.is_on_floor():
		Transition.emit(self, "Default")
