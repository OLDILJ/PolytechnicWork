extends CharacterBody3D


#base accel in m/s
@export var speed = 1
#downward accel in m/s^2
@export var downward_accel = 20
var target_velocity = Vector3.ZERO

func _process(delta):
	var direction = Vector3.ZERO
	
	if Input.is_action_pressed("td.right"):
		direction.x += 1
	if Input.is_action_pressed("td.left"):
		direction.x -= 1
	if Input.is_action_pressed("td.forward"):
		direction.z += 1
	if Input.is_action_pressed("td.back"):
		direction.z -= 1
		
	if direction != Vector3.ZERO:
		direction = direction.normalized()
	
	target_velocity.x = direction.x * speed
	target_velocity.z = direction.z * speed
	
	#if not is_on_floor(): # If in the air, fall towards floor. gravity
	#	target_velocity.y = target_velocity.y - (downward_accel * delta)
	
	velocity = target_velocity
	move_and_slide()
