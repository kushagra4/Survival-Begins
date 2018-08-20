using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour {
	public static float distanceFromTarget;
	public float toTarget;
	public Camera fpscam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if(Physics.Raycast(fpscam.transform.position, fpscam.transform.TransformDirection(Vector3.forward), out hit)){
			toTarget = hit.distance;
			distanceFromTarget = toTarget;
	}
}
}
