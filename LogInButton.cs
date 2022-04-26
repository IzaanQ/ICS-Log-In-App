using Godot;
using System;

public class LogInButton : Button
{
// Variables
private Button LogIn;
private Panel MenuPanel;
private Panel LogPanel;
private Tween tween;

	public override void _Ready()
	{
		// Getting the nodes of the Login button and other panels.
		LogIn = GetNode<Button>("LogInButton");
		MenuPanel = GetNode<Panel>("/root/Control/Background/MenuPanel");
		LogPanel = GetNode<Panel>("/root/Control/Background/LogPanel");
		tween = GetNode<Tween>("/root/Control/Background/MenuPanel/Tween");
	}

	// On login button press...
	private void OnLogInButtonPressed()
	{
	GD.Print("Log In Button Pressed");
	MenuPanel.Visible = false;
	LogPanel.Visible = true;
	}
}

