extends CharacterBody2D
var Gravity = 900

func _physics_process(delta: float) -> void:
	if not is_on_floor():
		#print("Applying Gravity")
		velocity.y += delta * Gravity
	move_and_slide()


func _on_area_2d_area_entered(area: Area2D) -> void:
	print("collided")
	if area.is_in_group("Stomp"):
		queue_free()
