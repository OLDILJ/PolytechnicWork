extends Node3D
@onready var yaw_node = $CharacterBody3D/CameraRoot/Camyaw
@onready var pitch_node = $CharacterBody3D/CameraRoot/Camyaw/CamPitch
@onready var tps_camera = $CharacterBody3D/CameraRoot/Camyaw/CamPitch/Camera3D
@export var CameraMode = (false)
#@onready var pivot = $CharacterBody3D/SpringArm3D
var ray_origin = Vector3()
var ray_target = Vector3()
var look_at_me
var past_look_at_me
var sens = 1

var yaw : float = 0
var pitch : float = 0
var yaw_sensitivity : float = 0.07
var pitch_sensitivity : float = 0.07
var yaw_acceleration : float = 15
var pitch_acceleration : float = 15

var pitch_max : float = 80
var pitch_min : float = -80
# Topdown Camera Controls
# Point Topdown camera at thirdperson camera intersect
func topdown():
	
	var mouse_pos = get_viewport().get_mouse_position()
	#print("mouse pos:", mouse_pos) #get mouse position from window in pixels i.e 0,0 for top left
	var ray_length = 2000
	ray_origin = $TOPDOWN.project_ray_origin(mouse_pos)
	#print("ray_origin:", ray_origin)
	ray_target = ray_origin + $TOPDOWN.project_ray_normal(mouse_pos) * ray_length
	
	var space_state = get_world_3d().direct_space_state
	var ray_query = PhysicsRayQueryParameters3D.new()
	ray_query.from = ray_origin
	ray_query.to = ray_target
	ray_query.collide_with_areas = true
	var intersection = space_state.intersect_ray(ray_query)
	
	if not intersection.is_empty():
		#print("notempty")
		var pos = intersection.position
		$CharacterBody3D/Crosshair.position = intersection.position
		look_at_me = Vector3(pos.x, $CharacterBody3D.position.y, pos.z)
		#var look_at_me = Vector3(pos.x, pos.y, pos.z)
		$CharacterBody3D.look_at(look_at_me, Vector3.UP)
		#print(look_at_me)

# Point thirdperson camera at $Crosshair
#func ThirdPerson():


func _input(event):
	if event is InputEventMouseMotion and !CameraMode:
			yaw += -event.relative.x * yaw_sensitivity
			pitch += event.relative.y * pitch_sensitivity
func _physics_process(delta):
	if Input.is_action_just_pressed("swap"):
		CameraMode = !CameraMode
		print("swapping perspective")
	if CameraMode:
		#look_at_me = past_look_at_me
		$CharacterBody3D/Crosshair.visible = true
		$TOPDOWN.set_current(true)
		topdown()
		Input.mouse_mode = Input.MOUSE_MODE_CONFINED_HIDDEN
		#print("top down mode activated")
	else:
		pitch = clamp(pitch, pitch_min, pitch_max)
		yaw_node.rotation_degrees.y = lerp(yaw_node.rotation_degrees.y, yaw, yaw_acceleration * delta)
		pitch_node.rotation_degrees.x = lerp(pitch_node.rotation_degrees.x, pitch, pitch_acceleration * delta)
		$CharacterBody3D/Crosshair.visible = false
		#past_look_at_me = (look_at_me)
		$TOPDOWN.set_current(false)
		Input.mouse_mode = Input.MOUSE_MODE_CONFINED_HIDDEN
		#Thirdperson()
		#print("third person mode activated")
