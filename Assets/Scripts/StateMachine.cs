using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StateMachine : MonoBehaviour {

	//public Text content;
	public TextMeshProUGUI content;
	public Text option1;
	public Text option2;
	public Text option3;

	public Animator textController;

	private enum States 
	{
		HelloState,
		Question1State,
		Question2State,
	};

	private States myState;

	void Start () 
	{
		myState = States.HelloState;
	}
		
	void Update () 
	{
		if (myState == States.HelloState) 				{Hello ();}
		else if (myState == States.Question1State) 			{Question1 ();}
		else if (myState == States.Question2State) 			{Question2 ();}
	}
		
	

	void Hello(){
		content.text = "Hey! What brings a guy like you to this dive?";
		option1.text = "I'm in need of an adventurer!";
		option2.text = "The rats in my basement...";
		option3.text = "Looking for a drink.";

		textController.SetTrigger ("NewDialogue");

		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			myState = States.HelloState;
		} 
		else if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			myState = States.Question1State;
		} 
		else if (Input.GetKeyDown (KeyCode.Alpha3)) 
		{
			myState = States.Question2State;
		}
	}

	void Question1(){
		content.text = "Question1";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.HelloState;
		}
	}

	void Question2(){
		content.text = "Question2";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.HelloState;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.Question1State;
		} 
	}
	


}