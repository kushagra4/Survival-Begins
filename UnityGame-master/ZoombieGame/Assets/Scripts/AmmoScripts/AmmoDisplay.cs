using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour {

	public static int CurrentAmmo;
	public int InternalAmmo;
	public GameObject AmDisplay;
	public static int LoadedAmmo;
	public int InternalLoaded;
	public GameObject LoadedDisplay;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		InternalAmmo = CurrentAmmo;
		InternalLoaded = LoadedAmmo;

		AmDisplay.GetComponent<Text>().text="" + InternalAmmo;
		LoadedDisplay.GetComponent<Text>().text="" + LoadedAmmo;
		
	}
}
