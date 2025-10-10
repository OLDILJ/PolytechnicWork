extends Node

# First give it a class name so I can easily reference it in another script
class_name State

signal Transition

# step 1: what do I do when I transition *to* this state
# step 1.1: do all that stuff
# step 2: what do I do when I transition *out* of this state
# step 3: any other stuff I need to do?
# step 4 if anything happens call the transition signal.


func Enter():
	pass

func Exit():
	pass

func Update(_delta: float):
	pass

func PhysicsUpdate(_delta: float):
	pass
