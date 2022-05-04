using Godot;
using System;

public class LogOn : Button
{
	private Button login;
	private Panel LogPanel;
	private LineEdit UsernameInput;
	private LineEdit PasswordInput;
	private LineEdit UsernameInput2;
	private LineEdit PasswordInput2;
	private Label IncorrectPrompt;
	private Panel ChatPanel;
	private Panel MenuPanel;

	
	public override void _Ready()
	{
		login = GetNode<Button>("/root/Control/Background/LogPanel/LogOn");
		LogPanel = GetNode<Panel>("/root/Control/Background/LogPanel");
		UsernameInput = GetNode<LineEdit>("/root/Control/Background/LogPanel/UsernameInput");
		PasswordInput = GetNode<LineEdit>("/root/Control/Background/LogPanel/PasswordInput");
		UsernameInput2 = GetNode<LineEdit>("/root/Control/Background/SignUpPanel/UsernameInput");
		PasswordInput2 = GetNode<LineEdit>("/root/Control/Background/SignUpPanel/PasswordInput");
		IncorrectPrompt = GetNode<Label>("/root/Control/Background/LogPanel/IncorrectPrompt");
		ChatPanel = GetNode<Panel>("/root/Control/Background/ChatPanel");
		MenuPanel = GetNode<Panel>("/root/Control/Background/MenuPanel");

	}
	
	// On log on buton pressed.
	private void _on_LogOn_pressed()
	{
		// if username input and password input are the same as the ones stored in the sign up panel, then proceed to the chatroom.
		if (UsernameInput.Text == UsernameInput2.Text && PasswordInput.Text == PasswordInput2.Text)
		{
			IncorrectPrompt.Text = "Success!";
			IncorrectPrompt.Visible = true;
			GD.Print("Username Correct!");
			GD.Print("Password Correct!");
			ChatPanel.Visible = true;
			LogPanel.Visible = false;
			MenuPanel.Visible = false;
			
		}
		
		else
		{
			// incorrect password or username.
			IncorrectPrompt.Text = "Username or Password is incorrect. Try again.";
			IncorrectPrompt.Visible = true;
			GD.Print("Username or password is incorrect");
		}
	}


}



