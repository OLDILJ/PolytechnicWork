extends State

class_name PlayerAttack

@export_category("ToggleBool")
@export_category("Attacks")
@export var LightAttack1 : Node
@export var LightAttack2 : Node
@export var LightAttack3 : Node
@export var LightAttack4 : Node
@export var HeavyAttack1 : Node
@export var HeavyAttack2 : Node
@export var HeavyAttack3 : Node
@export var SpecialAttack1 : Node
@export var SpecialAttack2 : Node
@export var SpecialAttack3 : Node
@export_category("Animation")
@export var AnimTree : AnimationTree
@export var AnimBlend = 1
@export var Player : CharacterBody3D
@onready var AnimState = AnimTree["parameters/PlayerAnimState/playback"]

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func PhysicsUpdate(delta: float) -> void:
	pass
