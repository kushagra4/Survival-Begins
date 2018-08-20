using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ReSpawn : MonoBehaviour {

	
	
	
	private Vector3[]  SpawnLoc = {new Vector3(-28.6f,-10.59f,35.67f),new Vector3(1.18f,-10.6f,47.9f),new Vector3(-12.6f,1.1f,10.2f), new Vector3(0.0f,0.97f,5.6f) };
	public static  int enemycount = 0;
	public GameObject bloodfab;
	public GameObject prefabToSpawn;
	public List<GameObject> zombies;
	GameObject zombie;


	private float myTimmer=0;
	
	// Use this for initialization
	void Spawn ()
	{
		
			
			
			int r = UnityEngine.Random.Range (0, 4); 

			int i = 0;
			enemycount++;
			i=enemycount;
			TagHelper.AddTag(i+"");
			//zombies.Add
			GameObject currentZombie;
			currentZombie  = (Instantiate (prefabToSpawn, SpawnLoc [r], Quaternion.identity));
			currentZombie.name = "zombie" + i;
			//Instantiate (prefabToSpawn, SpawnLoc [r], Quaternion.identity).gameObject.tag= (i + "");
		 //  ZombieScript.AddTag(enemycount + "");
			//enemycount + "";

				
			


		}

	
	
	// Use this for initialization
	void Start () {
		bloodfab= GameObject.Find("effect_blood");
		
		
	}
	

	// Update is called once per frame
	void Update ()
	{
		myTimmer += Time.deltaTime;
		if (myTimmer > 1)
		{
			
			Spawn();
			myTimmer = 0;
		}
		
	}
}
