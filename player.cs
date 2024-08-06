using Godot;
using System;

public partial class player : Node2D
{
	[Export]
	int team = 0;

	[Export]
	float speed = 100;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float dir = Input.GetAxis("left" + team, "right" + team);

		Position = Position.MoveToward(new Vector2(Position.X + (speed * dir), Position.Y), (float)delta);








	}



}
