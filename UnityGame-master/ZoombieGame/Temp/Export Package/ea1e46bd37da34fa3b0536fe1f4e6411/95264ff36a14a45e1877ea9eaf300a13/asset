using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnim : MonoBehaviour
{
	public GameObject UpCurs;
	public GameObject LeftCurs;
	public GameObject RightCurs;
	
	public float myTime = 0.0F;
	public float nextFire = 0.1F;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myTime = myTime + Time.deltaTime;
		if (AmmoDisplay.CurrentAmmo>0){
			if (Input.GetButton("Fire1") && myTime > nextFire)
			{
				UpCurs.GetComponent<Animator>().enabled = true;
				LeftCurs.GetComponent<Animator>().enabled = true;
				RightCurs.GetComponent<Animator>().enabled = true;
				myTime = 0.0F;
			}
			
		}
		if (myTime > 0.1)
		{
			UpCurs.GetComponent<Animator>().enabled = false;
			LeftCurs.GetComponent<Animator>().enabled = false;
			RightCurs.GetComponent<Animator>().enabled = false;
		
		}
	}


}
