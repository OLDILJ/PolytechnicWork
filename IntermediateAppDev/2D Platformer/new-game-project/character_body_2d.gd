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
		for i in area.owner.get_children():
			print(area.owner.get_children())
			var BounceEntity = area.owner.get_node("Player")
			print(BounceEntity)
			BounceEntity.velocity.y = BounceEntity.velocity.y - 400
		#area.owner.velocity.y = area.owner.velocity.y - 900
		queue_free()
