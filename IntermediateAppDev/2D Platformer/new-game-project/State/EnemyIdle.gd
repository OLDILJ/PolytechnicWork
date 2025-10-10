extends State

class_name EnemyIdle

@export var Enemy: CharacterBody2D
@export var moveSpeed := 10

var moveDirection : Vector2
var wanderTime : float

func randomizeWander():
	moveDirection = Vector2(randf_range(-1,1), 0).normalized()
	wanderTime = randf_range(1,2)

func Enter():
	randomizeWander()


func Update(delta: float):
	if wanderTime > 0:
		wanderTime -= delta
	else:
		randomizeWander()

func PhysicsUpdate(delta: float):
	if Enemy:
		Enemy.velocity = moveDirection * moveSpeed
