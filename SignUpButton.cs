using Godot;
using System;

public class SignUpButton : Button
{
	private Button SignUp;
	private Panel MenuPanel;
	private Panel SignUpPanel;


	public override void _Ready()
	{
		SignUp = GetNode<Button>("/root/Control/Background/MenuPanel/SignUpButton");
		MenuPanel = GetNode<Panel>("/root/Control/Background/MenuPanel");
		SignUpPanel = GetNode<Panel>("/root/Control/Background/SignUpPanel");
		
	}
	
	// On sign up button pressed
	private void OnSignUpButtonPressed()
	{
	// takes you to the sign up panel UI
	GD.Print("Sign Up Button Pressed");
	MenuPanel.Visible = false;
	SignUpPanel.Visible = true;
	
	}

}
