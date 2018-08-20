using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

using System.Threading;

public class OpenDoor : MonoBehaviour {
	public GameObject textDisplay;
	public GameObject Door;
	public Animation anim;
	private bool door = false;
	private float myTime=0.0f;
	private float time=5.0f;
	private bool doorOpen=false;
	public float theDistance=PlayerCasting.distanceFromTarget;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
		theDistance = PlayerCasting.distanceFromTarget;
		myTime += Time.deltaTime;
		if (Input.GetButtonDown ("Action") && door ) {
			if (theDistance <= 10) {
				myTime = 0.0f;
				door = false;
				anim.Play("DOOROPEN");
				doorOpen = true;


			}
		}
		if(myTime>time && doorOpen){
			doorOpen = false;
			Debug.Log ("DoorCLose");
			anim.Play ("DOORCLOSE");
		}


	}
	void OnMouseEnter(){
		Debug.Log ("efrgthyhygtfrdeswer");
		if(theDistance<=10){
			//anim.Play ("OpenDoor");
			door=true;
			textDisplay.GetComponent<Text>().text = "Press o to Open ";
		}
	}
	void  OnMouseExit(){
		textDisplay.GetComponent<Text>().text =" ";
	}
    


}
