using Godot;
using System;

public class ExitButton2 : Button
{
	private Button exitbutton1;
	private Panel SignUpPanel;
	private Panel MenuPanel;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		SignUpPanel = GetNode<Panel>("/root/Control/Background/SignUpPanel");
		MenuPanel = GetNode<Panel>("/root/Control/Background/MenuPanel");
		exitbutton1 = GetNode<Button>("ExitButton1");
	}

	private void OnExitButton2Pressed()
	{
		SignUpPanel.Visible = false;
		MenuPanel.Visible = true;
	}

}
