extends Node2D

class_name BaseState

@onready var animated_sprite = $CharacterBody2D/AnimatedSprite2D
@onready var change_state
@onready var persistent_state

func _physics_process(_delta):
	persistent_state.move_and_slide(persistent_state.vel, Vector2.UP)


#Set up some defaults and change stuff when the state changes
func setup(change_state, animated_sprite, persistent_state):
	self.change_state = change_state
	self.animated_sprite = animated_sprite
	self.persistent_state = persistent_state

# Movement functions
func move_right():
	pass

func move_left():
	pass
