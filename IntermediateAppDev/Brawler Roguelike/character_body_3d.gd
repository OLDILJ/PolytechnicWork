extends CharacterBody3D

@export_category("ToggleBool")
@export var Sprinting = false;
@export var DoubleTapToggle = false;
@export var DoubleTapDodgeToggle = false;
@export_category("Speed")
@export var SPEED = 5.0
@export var SprintMult = 2.0
@export var RotationSpeed = .01
@export_category("Animation")
@onready var AnimTree = $human/AnimationTree
@export var AnimBlend = 1
@onready var AnimTreeBlend = AnimTree.get("parameters/Blend2/blend_amount")


var Rotating = false;
signal DoubleTapTimerStart
signal DoubleTapDodgeStart
const DodgeDistance = 50
const JUMP_VELOCITY = 4.5
const BaseSpeed = 5.0

func ChangeBlend(NewVal):
	AnimBlend = NewVal
	AnimTree.set("parameters/Blend2/blend_amount", AnimBlend)
	
func _ready() -> void:
	AnimTree.set("parameters/Transition/transition_request", "Idle")
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
			AnimTree.set("parameters/Transition/transition_request", "Movement")
			ChangeBlend(1.5)
		else:
			print("Walking")
			DoubleTapToggle = true
			SPEED = BaseSpeed
			AnimTree.set("parameters/Transition/transition_request", "Movement")
			ChangeBlend(0.5)

	if Input.is_action_just_released("Forward"):
		Sprinting = false
		
	if Input.is_action_just_pressed("SLeft") or Input.is_action_just_pressed("SRight") or Input.is_action_just_pressed("Backward") :
		emit_signal("DoubleTapDodgeStart")
		if DoubleTapDodgeToggle:
			print("DodgeStart")
			var HorizontalDodgeDir = Input.get_axis("SLeft","SRight")
			var BackwardDodge = -Input.get_action_strength("Backward");
			print()
			var DodgeDirection = (transform.basis * Vector3(HorizontalDodgeDir, 0, BackwardDodge)).normalized()
			velocity.x = -DodgeDirection.x * DodgeDistance
			velocity.z = DodgeDirection.z * DodgeDistance
			move_and_slide()
			await get_tree().create_timer(0.1).timeout
			print("DodgeEnd")
		else:
			print("DodgeToggleOn")
			DoubleTapDodgeToggle = true
			
			
	# Handle jump.
	if Input.is_action_just_pressed("ui_accept") and is_on_floor():
		velocity.y = JUMP_VELOCITY
	if Input.is_action_just_pressed("180Turn") and is_on_floor():
		var destinationY = rotation.y + PI
		rotation.y = destinationY
	if Input.is_action_just_pressed("Backward"):
		SPEED = BaseSpeed/4
		AnimTree.set("parameters/Transition/transition_request", "Movement")
		ChangeBlend(0.4)

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
			AnimTree.set("parameters/Transition/transition_request", "Idle")
			

	else:
		velocity.x = 0
		velocity.z = 0
		AnimTree.set("parameters/Transition/transition_request", "Movement")
		ChangeBlend(0.33)

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


func _on_double_tap_dodge_timer_timeout() -> void:
	DoubleTapDodgeToggle = false
	pass # Replace with function body.
