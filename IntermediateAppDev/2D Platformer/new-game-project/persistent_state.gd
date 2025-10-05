extends CharacterBody2D

class_name PersistentState
@onready var anim = $AnimatedSprite2D
var state
var state_factory

var vel = Vector2()

func _ready():
	state_factory = StateFactory.new()
	change_state("idle")
	
func _process(_delta):
	if Input.is_action_pressed("Left"):
		move_left()
	elif Input.is_action_pressed("Right"):
		move_right()
	
func move_left():
		state.move_left()

func move_right():
		state.move_right()

func change_state(new_state_name):
	if state != null:
		state.queue_free()
	state = state_factory.get_state(new_state_name).new()
	state.setup(self, anim, self)
	state.name = "current_state"
	add_child(state)
