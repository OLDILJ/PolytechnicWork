extends CharacterBody3D

@export_category("ToggleBool")
@export var Sprinting = false;
@export var DoubleTapToggle = false;
@export_category("Speed")
@export var SPEED = 5.0
@export var SprintMult = 2.0
@export var RotationSpeed = .05
var Rotating = false;
signal DoubleTapTimerStart
const JUMP_VELOCITY = 4.5
const BaseSpeed = 5.0



func _physics_process(delta: float) -> void:
	# Add the gravity.
	if not is_on_floor():
		velocity += get_gravity() * delta
	if Input.is_action_just_pressed("Forward"):
		emit_signal("DoubleTapTimerStart")
		if DoubleTapToggle:
			Sprinting = true
			print("Sprinting")
			SPEED = BaseSpeed * SprintMult
		else:
			print("Walking")
			DoubleTapToggle = true
			SPEED = BaseSpeed
	if Input.is_action_just_released("Forward"):
		Sprinting = false
		
		
	# Handle jump.
	if Input.is_action_just_pressed("ui_accept") and is_on_floor():
		velocity.y = JUMP_VELOCITY
	if Input.is_action_just_pressed("180Turn") and is_on_floor():
		var destinationY = rotation.y + PI
		rotation.y = destinationY
	if Input.is_action_just_pressed("Backward"):
		SPEED = BaseSpeed/4
	# Get the input direction and handle the movement/deceleration.
	# As good practice, you should replace UI actions with custom gameplay actions.
	var input_dir := Input.get_vector("SRight", "SLeft", "Backward", "Forward")
	var direction := (transform.basis * Vector3(input_dir.x, 0, input_dir.y)).normalized()
	if !Rotating:
		if direction:
			velocity.x = direction.x * SPEED
			velocity.z = direction.z * SPEED
		else:
			velocity.x = move_toward(velocity.x, 0, SPEED)
			velocity.z = move_toward(velocity.z, 0, SPEED)
	else:
		velocity.x = 0
		velocity.z = 0
	var rotationDir := Input.get_axis("Left","Right")
	if rotationDir:
		Rotating = true
		rotation.y = rotate_toward(rotation.y, rotation.y - rotationDir, RotationSpeed)
	if rotationDir == 0:
		Rotating = false
	else:
		Rotating = true
		rotation.y = rotate_toward(rotation.y, rotation.y - rotationDir, RotationSpeed)
		
	move_and_slide()
	
func _on_double_tap_timer_timeout() -> void:
	DoubleTapToggle = false
	pass # Replace with function body.
