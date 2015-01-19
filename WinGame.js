#pragma strict
//this is my trigger event to capture if the player hits the box collider. If so you win.
function OnTriggerEnter ()
{
//loads the win screen
Application.LoadLevel("YouEscaped");
}