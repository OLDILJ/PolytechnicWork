extends State

class_name PlayerController

@export var Player: CharacterBody2D
@export var AnimationSprite: AnimatedSprite2D

@export var moveSpeed := 100

var moveDirection : Vector2
var friction = 0.95


func PhysicsUpdate(delta: float):
	
	if Input.is_action_pressed("Right"):
		print("Sending Right Signal")
		moveDirection = Vector2(1,0)
	if Input.is_action_pressed("Left"):
		print("Sending Left Signal")
		moveDirection = Vector2(-1,0)
	if Input.is_action_pressed("Jump"):
		print("Sending Jump Signal")
		Transition.emit(self, "jump")
	
	if Player:
		Player.velocity.x = moveDirection.x * moveSpeed
		moveDirection = moveDirection * friction
		print(Player.velocity.x)
		AnimationSprite.play("Run")
		if abs(Player.velocity.x) < 15:
			print("Emergency Halt")
			Player.velocity.x = 0
			moveDirection = Vector2.ZERO
			AnimationSprite.play("Idle")
