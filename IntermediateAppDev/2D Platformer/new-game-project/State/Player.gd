extends CharacterBody2D
var idleFlip = true
# reminder that all movement stuff is done in States Check STATEMACHINE.gd and State.gd for more info
func _physics_process(delta):

	move_and_slide()
	
	if velocity.length() > 0 && velocity.y == 0:
		$AnimatedSprite2D.play("Run")
		idleFlip = true
	if velocity.y != 0:
		$AnimatedSprite2D.play("Jump")
	if velocity.x > 0.1:
		$AnimatedSprite2D.flip_h = false
	elif velocity.x < -0.1:
		$AnimatedSprite2D.flip_h = true
	if ( velocity.x >= -0.1 && velocity.x < 0.1):
		$AnimatedSprite2D.play("Idle")
		if (idleFlip):
			$AnimatedSprite2D.flip_h = not $AnimatedSprite2D.flip_h
			idleFlip = false 
		
