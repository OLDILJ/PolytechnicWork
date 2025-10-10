extends State

class_name PlayerController

@export var Player: CharacterBody2D

@export var moveSpeed := 10

var moveDirection : Vector2

func PhysicsUpdate(delta: float):
	var velocity = Vector2.ZERO
	if Input.is_action_pressed("Right"):
		print("Sending Right Signal")
		Transition.emit(self, "right")
	if Input.is_action_pressed("Left"):
		print("Sending Left Signal")
		Transition.emit(self, "left")
	if Input.is_action_pressed("Jump"):
		print("Sending Jump Signal")
		Transition.emit(self, "jump")
