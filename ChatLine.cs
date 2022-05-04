using Godot;
using System;

public class ChatLine : LineEdit
{
	private LineEdit Chatline;
	private TextEdit ChatBox;
	private string ChatInput = "";
	private LineEdit UsernameInput;
	
	public override void _Ready()
	{
		Chatline = GetNode<LineEdit>("/root/Control/Background/ChatPanel/ChatLine");
		ChatBox = GetNode<TextEdit>("/root/Control/Background/ChatPanel/ChatBox");
		UsernameInput = GetNode<LineEdit>("/root/Control/Background/SignUpPanel/UsernameInput");
	}
	
	// When input is typed and entered..
	private void _on_ChatLine_text_entered(String new_text)
	{
		// store the input in a string and then display it and the username on the chatbox. Clear the chat line after.
		ChatInput = Chatline.Text;
		ChatBox.Text += UsernameInput.Text + ": " + ChatInput + "\n";
		Chatline.Clear();
		ChatBox.ScrollVertical = 999999;
	}
	
}



