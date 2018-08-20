using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour {
	public int DamageAmount = 5;
	public float  TargetDistance ;
	public int AllowRange = 15;
	public Camera fpscam=null;
	public Texture texture;
	private float myTime = 0.0F;
	private float nextFire = 0.1F;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		myTime = myTime + Time.deltaTime;
		if (AmmoDisplay.LoadedAmmo>0){
			if (Input.GetButton("Fire1") && myTime > nextFire)
			{
				RaycastHit Shot;
				if (Physics.Raycast(fpscam.transform.position, fpscam.transform.TransformDirection(Vector3.forward), out Shot))
				{
					TargetDistance = Shot.distance;
					if (TargetDistance < AllowRange) {
						Shot.transform.SendMessage ("DeductPoints", DamageAmount);
						Debug.Log (Shot.collider.tag);
						GameObject zombie = GameObject.Find (Shot.collider.name);
						if (Shot.collider.name.Contains ("zombie")) { 
							//tagname.tag = Shot.collider.tag;
							if (zombie != null) {
							

								Renderer[] renders = zombie.GetComponentsInChildren<Renderer> ();


								for (int i = 0; i < 9; i++) {
									int j = Random.Range (0, renders.Length);
									renders [j].material.mainTexture = texture;
									//UnityEngine.Debug.Log (wallTex + "");
								}
							}
						}
					}


					}
					myTime = 0.0F;
				}
				
			}
			else
			{
				//print reload
			}
		}

	}


