extends BaseState

class_name IdleState

func _ready():
	animated_sprite.play("idle")
# set up ability to flip the direction
func _flip_direction():
	animated_sprite.flip_h = not animated_sprite.flip_h
# check if the sprite is flipped if it is already flipped play the animation else flip it

func move_left():
	if animated_sprite.flip_h:
		change_state.call_func("run")
	else:
		_flip_direction()

# check if the sprite is *not* flipped if it isn't already flipped play the animation else flip it back

func move_right():
	if not animated_sprite.flip_h:
		change_state.call_func("run")
	else:
		_flip_direction()
