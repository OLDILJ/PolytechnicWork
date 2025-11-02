extends Control

@export_category("Moves")
@export var L1 : Label
@export var L1Move : Node
@export var L1Menu : MenuButton
@export var L2 : Label
@export var L2Move : Node
@export var L2Menu : MenuButton
@export var H1 : Label
@export var H1Move : Node
@export var H1Menu : MenuButton
@export var H2 : Label
@export var H2Move : Node
@export var H2Menu : MenuButton
@export var Attack : Node
var AttackDic = {}

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	for child in Attack.get_children():
		AttackDic[AttackDic.size()] = child.get_meta("MoveName")
	for child in get_children():
		if child is MenuButton:
			for key in AttackDic.keys():
				child.get_popup().add_item(AttackDic[key])

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	#TODO REPLACE CODE INTO TOGGLE FUNCTION NOT ON PROCESS
	L1.text = L1Move.get_meta("MoveName")
	L2.text = L2Move.get_meta("MoveName")
	H1.text = H2Move.get_meta("MoveName")
	H2.text = H2Move.get_meta("MoveName")
	


func _on_button_pressed() -> void:
	get_tree().reload_current_scene()
