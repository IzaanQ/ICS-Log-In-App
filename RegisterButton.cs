using Godot;
using System;

public class RegisterButton : Button
{
	private LineEdit UsernameInput;
	private LineEdit PasswordInput;
	private Button Register;
	private Panel SignUpPanel;
	private Label RegisterPrompt;
	public string Username = "username";
	public string Password = "password";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		UsernameInput = GetNode<LineEdit>("/root/Control/Background/SignUpPanel/UsernameInput");
		PasswordInput = GetNode<LineEdit>("/root/Control/Background/SignUpPanel/PasswordInput");
		Register = GetNode<Button>("/root/Control/Background/SignUpPanel/RegisterButton");
		SignUpPanel = GetNode<Panel>("/root/Control/Background/SignUpPanel");
		RegisterPrompt = GetNode<Label>("/root/Control/Background/SignUpPanel/RegisterPrompt");
	}

	// On register button pressed
	private void _on_RegisterButton_pressed()
	{
		// store the username input and password input in a string and then display a register prompt.
		Username = UsernameInput.Text;
		Password = PasswordInput.Text;
		RegisterPrompt.Visible = true;
		GD.Print("Username is: " + Username);
		GD.Print("Password is: " + Password);
		
	}
	
}



