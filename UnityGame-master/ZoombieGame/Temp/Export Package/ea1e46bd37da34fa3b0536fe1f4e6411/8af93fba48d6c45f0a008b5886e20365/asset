using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Api;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	public int currentHealth;

	public int maxHealth = 100;

	public float hbLength;
	
	// Use this for initialization
	void Start ()
	{
		currentHealth = maxHealth;
		hbLength = Screen.width / 2;
	}
	
	// Update is called once per frame
	void Update () {
		ChangeHealth(0);
		
	}

	void OnGUI()
	{
		GUI.Box(new Rect(10, 10, hbLength, 30), currentHealth + "/" + maxHealth);
	}

	public void ChangeHealth(int health)
	{
		currentHealth += health;
		hbLength = (Screen.width / 2) * (currentHealth / (float) maxHealth);
	}
}
