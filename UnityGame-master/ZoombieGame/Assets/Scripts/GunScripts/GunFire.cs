using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {


	public Animation anim;
	public GameObject other;
	public AudioSource AmmoSound;
	public ParticleSystem ps;
	private bool reload=false;
	private float myTime = 0.0F;
	private float nextFire = 0.1F;
	private float time=0.0f;	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();

	}

	// Update is called once per frame
	void Update () {
		myTime = myTime + Time.deltaTime;

		if(reload){
			time += Time.deltaTime;
			if ( time > 2.0f) {
				
				anim.Stop ("MachineGun_reload");
				Debug.Log ("dfghgfdw");
				reload = false;
				time = 0;
			}

			
		}
		if(!reload && Input.GetButton("Fire1") && AmmoDisplay.LoadedAmmo>0 && myTime > nextFire){


			AmmoSound.Play();
			ps.Play();
			anim.Play("MachineGin_shoot");
			//ParticleSystem ps1=gameObject.FindGameObjectsWithTag("Particle System ").GetComponent<ParticleSystem>();
			//ps1.enableEmission = true;
			//other.particleSystem.Emit(5);
			AmmoDisplay.LoadedAmmo -= 1;
			
			myTime = 0.0F;


		}
		if (AmmoDisplay.CurrentAmmo > 0 && AmmoDisplay.LoadedAmmo == 0) {
			AmmoDisplay.CurrentAmmo -= 10;
			AmmoDisplay.LoadedAmmo = 10;
			reload = true;
			anim.Play("MachineGun_reload");

		}
		if (Input.GetKey ("r")) {
			if (AmmoDisplay.CurrentAmmo > 0) {
				AmmoDisplay.CurrentAmmo -= 10;
				AmmoDisplay.LoadedAmmo = 10;
				anim.Play("MachineGun_reload");
			}

		}

	}
}
