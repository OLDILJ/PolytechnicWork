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
var isPaused = false;
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



	if Input.is_action_just_pressed("SLeft") or Input.is_action_just_pressed("SRight") or Input.is_action_just_pressed("Backward") :
		emit_signal("DoubleTapDodgeStart")
		if DoubleTapDodgeToggle:
			print("DodgeStart");
			var HorizontalDodgeDir = -Input.get_axis("SLeft","SRight")
			var BackwardDodge = -Input.get_action_strength("Backward");
			var DodgeDirection = (transform.basis * Vector3(HorizontalDodgeDir, 0, BackwardDodge)).normalized()
			print(DodgeDirection);
			if BackwardDodge != 0:
				AnimTree.set("parameters/Transition/transition_request", "Movement")
			else:
				AnimTree.set("parameters/Transition/transition_request", "")
			velocity.x = DodgeDirection.x * DodgeDistance
			velocity.z = DodgeDirection.z * DodgeDistance
			move_and_slide()
			await get_tree().create_timer(0.1).timeout
			print("DodgeEnd")
		else:
			print("DodgeToggleOn")
			DoubleTapDodgeToggle = true

	move_and_slide()
	



func _on_double_tap_dodge_timer_timeout() -> void:
	DoubleTapDodgeToggle = false
