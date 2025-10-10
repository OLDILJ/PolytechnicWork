extends CharacterBody2D

# reminder that all movement stuff is done in States Check STATEMACHINE.gd and State.gd for more info
func _physics_process(delta):
	move_and_slide()
	
	if velocity.length() > 0 && velocity.y == 0:
		$AnimatedSprite2D.play("Run")
	if velocity.y != 0:
		$AnimatedSprite2D.play("Jump")
	if velocity.x > 0:
		$AnimatedSprite2D.flip_h = false
	else:
		$AnimatedSprite2D.flip_h = true
