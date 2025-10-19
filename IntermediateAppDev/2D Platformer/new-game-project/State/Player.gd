extends CharacterBody2D
var idleFlip = true
var Gravity = 900
@export var StompHitbox : Area2D
@export var InteractHitbox : Area2D
# reminder that all movement stuff is done in States Check STATEMACHINE.gd and State.gd for more info
func _physics_process(delta):

	move_and_slide()
	
	if velocity.length() > 0 && velocity.y == 0:
		idleFlip = true
	if not is_on_floor():
		#print("Applying Gravity")
		velocity.y += delta * Gravity
		StompHitbox.monitoring = true
	else:
		StompHitbox.monitoring = false
	if velocity.x > 0.1:
		$AnimatedSprite2D.flip_h = false
	elif velocity.x < -0.1:
		$AnimatedSprite2D.flip_h = true
	if ( velocity.x >= -0.1 && velocity.x < 0.1):
		if (idleFlip):
			$AnimatedSprite2D.flip_h = not $AnimatedSprite2D.flip_h
			idleFlip = false 
		
