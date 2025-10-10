extends State

class_name PlayerIdle

@export var Player: CharacterBody2D
@export var move_speed := 10

var move_direction : Vector2
var wander_time : float

func randomize_wander():
	move_direction = Vector2(randf_range(-1,1), randf_range(-1,1)).normalized()
	wander_time = randf_range(1,4)

func Enter():
	randomize_wander()
	
func Update(delta: float):
	if wander_time > 0:
		wander_time -= delta
	else:
		randomize_wander()

func PhysicsUpdate(delta: float):
	if Player:
		Player.velocity = move_direction * move_speed
