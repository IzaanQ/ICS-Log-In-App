using Godot;
using System;

public class LogInButton : Button
{
// Variables
	private Button LogIn;
	private Panel MenuPanel;
	private Panel LogPanel;

	public override void _Ready()
	{
		// Getting the nodes of the Login button and other panels.
		LogIn = GetNode<Button>("/root/Control/Background/MenuPanel/LogInButton");
		MenuPanel = GetNode<Panel>("/root/Control/Background/MenuPanel");
		LogPanel = GetNode<Panel>("/root/Control/Background/LogPanel");
	}
	
	private void _on_LogInButton_pressed()
	{
		// on button press, takes you to the log in panel.
		MenuPanel.Visible = false;
		LogPanel.Visible = true;
	}
}







