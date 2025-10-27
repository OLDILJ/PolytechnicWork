extends State

class_name PlayerMovement

@export_category("ToggleBool")
@export var Sprinting = false;
@export var DoubleTapToggle = false;
@export var DoubleTapDodgeToggle = false;
@export_category("Speed")
@export var SPEED = 5.0
@export var SprintMult = 2.0
@export var RotationSpeed = .01
@export_category("Animation")
@export var AnimTree : AnimationTree
@export var AnimBlend = 1
# @onready var AnimTreeBlend = AnimTree.get("parameters/Blend2/blend_amount")
@export var Player : CharacterBody3D
@onready var AnimState = AnimTree["parameters/PlayerAnimState/playback"]

var Is_Walking
var Is_Running
var Rotating = false;
signal DoubleTapTimerStart
signal DoubleTapDodgeStart
const DodgeDistance = 50
const JUMP_VELOCITY = 4.5
const BaseSpeed = 5.0
# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func PhysicsUpdate(delta: float) -> void:
	if Input.is_action_just_pressed("Forward"):
		emit_signal("DoubleTapTimerStart")
		if DoubleTapToggle:
			Sprinting = true
			Is_Walking = false
			print("Is Walking Check ", (Is_Walking))
			print("Sprinting")
			SPEED = BaseSpeed * SprintMult
			Player.ChangeBlend(1.5)
		else:
			print("Walking")
			print("Is Walking Check ", (Is_Walking))
			DoubleTapToggle = true
			SPEED = BaseSpeed
			Is_Walking = true
			Player.ChangeBlend(0.5)

	if Input.is_action_just_released("Forward"):
		Sprinting = false

	if Input.is_action_just_pressed("180Turn") and Player.is_on_floor():
		var destinationY = Player.rotation.y + PI
		Player.rotation.y = destinationY
	if Input.is_action_just_pressed("Backward"):
		SPEED = BaseSpeed/4
		AnimTree.set("parameters/Transition/transition_request", "Movement")
		Player.ChangeBlend(0.4)

	var input_dir := Input.get_vector("SRight", "SLeft", "Backward", "Forward")
	var direction := (Player.transform.basis * Vector3(input_dir.x, 0, input_dir.y)).normalized()
	if !Rotating:
		if direction:
			Player.velocity.x = direction.x * SPEED
			Player.velocity.z = direction.z * SPEED
		else:
			Player.velocity.x = move_toward(Player.velocity.x, 0, SPEED)
			Player.velocity.z = move_toward(Player.velocity.z, 0, SPEED)

	var rotationDir := Input.get_axis("Left","Right")
	if rotationDir:
		Rotating = true
		Player.rotation.y = rotate_toward(Player.rotation.y, Player.rotation.y - rotationDir, RotationSpeed)
	if rotationDir == 0:
		Rotating = false
	else:
		Rotating = true
		Player.rotation.y = rotate_toward(Player.rotation.y, Player.rotation.y - rotationDir, RotationSpeed)
		
func _on_double_tap_timer_timeout() -> void:
	DoubleTapToggle = false
