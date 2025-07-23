extends Node3D

@onready var RayCast = $RayCast3D
@onready var laser_mask = $CSGCombiner3D/CSGBox3D
# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	var object = RayCast.get_collider()
	var hittpoint = RayCast.get_collision_point()
	
	if object != null:
		laser_mask.height = hittpoint.distance_to(laser_mask.global_transform.origin) * 2
	else:
		laser_mask.height = 0.01
