extends Area2D

@export var Collision : CollisionShape2D
@export_range(32,128,1, "Area Total Size") var areaSize
@export var Text : Label
@export var EnterText = ""
@export var ExitText = ""
# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	
	var Shape = Collision.get_shape()
	Shape.size = Vector2(areaSize,areaSize)
	print(Shape.size)



# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	pass


func _on_area_entered(area: Area2D) -> void:
	print("Collided With Interact Area")
	if area.is_in_group("InteractHitbox"):
		print("Interact Hitbox Collision")
		Text.text = EnterText




func _on_area_exited(area: Area2D) -> void:
	if area.is_in_group("InteractHitbox"):
		print("Interact Hitbox Collision")
		Text.text = ExitText
