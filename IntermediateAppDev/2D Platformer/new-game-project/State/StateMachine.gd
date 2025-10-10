extends Node

@export var initialState : State

# I need somewhere to store the states. put them in a dictionary.
# I also need to define that the current state is a "State"

@export var currentState : State

@export var states : Dictionary = {}

# check all the children of this specific state machine
# if there are states attached to the machine add it to the dictionary.
## note im testing just adding stuff to the dictionary on ready/boot but I may fiddle with doing it dynamically if this works out.
func _ready():
	for child in get_children():
		if child is State:
			states[child.name.to_lower()] = child
			child.Transition.connect(onChildTransition)
	if initialState:
		initialState.Enter()
		currentState = initialState

func _process(delta):
	if currentState:
		currentState.Update(delta)

func _physics_process(delta):
	if currentState:
		currentState.PhysicsUpdate(delta)

func onChildTransition(state, newStateName):
	#check its not trying to transition into itself
	if state != currentState:
		return
		
	#define the new state and check through the dictionary if it exists
	var newState = states.get(newStateName.to_lower())
	if !newState:
		return
	
	if currentState:
		currentState.Exit()
	
	newState.Enter()
	
	currentState = newState
