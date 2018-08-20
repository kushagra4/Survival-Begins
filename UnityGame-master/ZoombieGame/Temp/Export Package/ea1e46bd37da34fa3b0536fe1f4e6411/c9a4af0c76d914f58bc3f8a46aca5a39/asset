using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
	public int EnemeyHealth=10;
	// Use this for initialization
	void DeductPoints(int DamageAmount){
		EnemeyHealth -= DamageAmount;
	}

	// Update is called once per frame
	void Update () {

		if (EnemeyHealth <= 0) {
			Destroy (gameObject);
		}
	}
}