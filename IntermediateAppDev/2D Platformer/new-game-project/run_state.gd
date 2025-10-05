extends BaseState
# name the class
class_name runState
# set up some vars
# move speed for move speed and a minimum move speed for this state to be active
var move_speed = Vector2(200, 0)
var min_move_speed = 0.01
var friction = 0.4

func _ready():
	animated_sprite.play("Run")
	# if the animation is flipped flip movespeed
	if animated_sprite.flip_h:
		move_speed.x *= -1
	persistent_state.velocity += move_speed
	
func _physics_process(_delta):
	# get the absolute value of the current velocity if its below the minimum move speed call the idle function
	if abs(persistent_state.velocity.x) < min_move_speed:
		change_state.call_func("idle")
	persistent_state.velocity.x *= friction


func move_left():
	if animated_sprite.flip_h:
		persistent_state.velocity += move_speed
	else:
		change_state.call_func("idle")


func  move_right():
	if not animated_sprite.flip_h:
		persistent_state.velocity += move_speed
	else:
		change_state.call_func("idle")
