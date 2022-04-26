using Godot;
using System;

public class SignUpButton : Button
{
	private Button SignUp;
	private Panel MenuPanel;
	private Panel SignUpPanel;


	public override void _Ready()
	{
		SignUp = GetNode<Button>("SignUpButton");
		MenuPanel = GetNode<Panel>("/root/Control/Background/MenuPanel");
		SignUpPanel = GetNode<Panel>("/root/Control/Background/SignUpPanel");
		
	}
	
	private void OnSignUpButtonPressed()
	{
	GD.Print("Sign Up Button Pressed");
	MenuPanel.Visible = false;
	SignUpPanel.Visible = true;
	
	}

}
