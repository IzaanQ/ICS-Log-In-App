using Godot;
using System;

public class SignOutButton : Button
{
	private Panel ChatPanel;
	private Panel MenuPanel;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ChatPanel = GetNode<Panel>("/root/Control/Background/ChatPanel");
		MenuPanel = GetNode<Panel>("/root/Control/Background/MenuPanel");
		
	}

	// On sign out button pressed
	private void _on_SignOutButton_pressed()
	{
		// turn the chatroom ui invisible and the menu panel visible
		ChatPanel.Visible = false;
		MenuPanel.Visible = true;
	
	}
}



