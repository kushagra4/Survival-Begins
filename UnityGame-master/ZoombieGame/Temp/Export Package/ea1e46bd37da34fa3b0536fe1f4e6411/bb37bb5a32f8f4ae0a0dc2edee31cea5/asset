using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncAmmo : MonoBehaviour {
	public AudioSource AmmoPickSound;
	
	void update(){
		if (AmmoDisplay.LoadedAmmo == 0 && AmmoDisplay.CurrentAmmo > 0) {
			
			AmmoDisplay.LoadedAmmo =10;
			AmmoDisplay.CurrentAmmo -= 10;
		}
	}
	void OnTriggerEnter(Collider col){
			AmmoPickSound.Play ();
		if (AmmoDisplay.LoadedAmmo == 0) {
			AmmoDisplay.LoadedAmmo += 10;
			this.gameObject.SetActive(false);
		}
		else{
	
			AmmoDisplay.CurrentAmmo += 10;

			this.gameObject.SetActive(false);

	}

}
}
