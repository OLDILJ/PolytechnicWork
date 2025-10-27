extends State

class_name PlayerIdle

@export var AnimTree : AnimationTree
@export var AnimBlend = 1
# @onready var AnimTreeBlend = AnimTree.get("parameters/Blend2/blend_amount")
@export var Player : CharacterBody3D
@onready var AnimState = AnimTree["parameters/PlayerAnimState/playback"]


func Enter():
	print("Enter Idle");
	AnimState.travel("Idle")
	
func PhysicsUpdate(delta: float):
	if Input.is_anything_pressed():
		Transition.emit(self,"Movement")
