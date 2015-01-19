#pragma strict

function Start () {
	//pauses the function for X seconds
	yield WaitForSeconds (3);
	
	//loads the homescreen
	Application.LoadLevel ("HomeScreen");
}

