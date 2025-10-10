extends State

class_name PlayerController

@export var Player: CharacterBody2D

@export var moveSpeed := 100

var moveDirection : Vector2
var friction = 0.4


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
		Player.velocity = moveDirection * moveSpeed
