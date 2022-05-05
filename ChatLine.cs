using Godot;
using System;

public class ChatPanel : Panel
{
	private Panel Chat;
	private TextEdit ChatBox;
	private LineEdit ChatLine;
	private Button SignOut;
	private LineEdit IpAddress;
	private Button JoinRoom;
	private Button HostRoom;
	private Panel MenuPanel;
	private LineEdit UsernameInput;
	string username = "";
	string message = "";
	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Chat = GetNode<Panel>("/root/Control/Background/ChatPanel");
		ChatBox = GetNode<TextEdit>("/root/Control/Background/ChatPanel/ChatBox");
		ChatLine = GetNode<LineEdit>("/root/Control/Background/ChatPanel/ChatLine");
		SignOut = GetNode<Button>("/root/Control/Background/ChatPanel/SignOutButton");
		IpAddress = GetNode<LineEdit>("/root/Control/Background/ChatPanel/IpAddress");
		JoinRoom = GetNode<Button>("/root/Control/Background/ChatPanel/JoinRoom");
		HostRoom = GetNode<Button>("/root/Control/Background/ChatPanel/HostRoom");
		MenuPanel = GetNode<Panel>("/root/Control/Background/MenuPanel");
		UsernameInput = GetNode<LineEdit>("/root/Control/Background/LogPanel/UsernameInput");
		
	}
	
	public void _on_JoinRoom_button_up()
	{
		var ip = IpAddress.Text;
		var client = new NetworkedMultiplayerENet();
		var result = client.CreateClient(ip, 4321);
		GetTree().NetworkPeer = client;
		
	}
	
	public void _on_HostRoom_button_up()
	{	
		var host = new NetworkedMultiplayerENet();
		host.CreateServer(4321, 32);
		GetTree().NetworkPeer = host;
		

	}	
	
	public void _on_ChatLine_text_entered(String message)
	{
		message = ChatLine.Text;
		username = UsernameInput.Text;
		Rpc("ReceiveMessage", username, message);
		ChatLine.Text = "";
		ChatBox.Text += username + ": " + message + "\n";
		ChatBox.ScrollVertical = 99999999999;
	}
	
	private void _on_SignOutButton_button_up()
	{
		Chat.Visible = false;
		MenuPanel.Visible = true;
	}
	
	
}








