using Godot;
using System;

public class ExitButton1 : Button
{
	private Button exitbutton1;
	private Panel LogPanel;
	private Panel MenuPanel;


	public override void _Ready()
	{
		LogPanel = GetNode<Panel>("/root/Control/Background/LogPanel");
		MenuPanel = GetNode<Panel>("/root/Control/Background/MenuPanel");
		exitbutton1 = GetNode<Button>("/root/Control/Background/LogPanel/ExitButton1");
	}
	
	// on exit button pressed.
	private void OnExitButton1Pressed()
	{
		// exits to the menu panel from the log panel.
		LogPanel.Visible = false;
		MenuPanel.Visible = true;
	}
	
}



