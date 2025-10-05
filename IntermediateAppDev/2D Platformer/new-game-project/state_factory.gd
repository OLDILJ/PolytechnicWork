extends Node

class_name StateFactory

var states

func _init():
	states = {
		"idle": IdleState,
		"run": runState
	}

func get_state(state_name):
	if states.has(state_name):
		return states.get(state_name)
	else:
		printerr(state_name, " Not found in state factory")
