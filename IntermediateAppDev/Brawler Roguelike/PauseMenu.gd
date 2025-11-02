extends Node3D
@export var PauseMenu : Control
var isPaused = false

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.

func PauseCheck():
	print("Pause")
	if isPaused:
		get_tree().paused = false
		isPaused = false
		PauseMenu.hide()
	else:
		isPaused = true
		PauseMenu.show()
		get_tree().paused = true

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	if Input.is_action_just_pressed("PAUSE"):
		PauseCheck()
