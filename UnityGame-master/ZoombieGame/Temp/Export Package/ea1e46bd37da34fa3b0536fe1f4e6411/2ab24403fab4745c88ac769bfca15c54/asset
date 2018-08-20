using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
	private Transform goal;
	public float dist;
	private float myTimmer=0;
	private bool isAttack = false;
	private PlayerHealth ph;
	private GameObject go;
	
	// Use this for initialization
	void Start () {
		goal = Camera.main.transform;
		go=GameObject.FindGameObjectWithTag("Player");
		ph = (PlayerHealth) go.GetComponent(typeof(PlayerHealth));
	}
	
	// Update is called once per frame
	void Update ()
	{
		myTimmer += Time.deltaTime;
		goal = Camera.main.transform;
		if (Vector3.Distance(goal.position, this.transform.position) < 2.5 && myTimmer>1.5)
		{
			dist = Vector3.Distance(goal.position, this.transform.position);
			GetComponent<Animation>().Play ("attack");
			myTimmer = 0;
			isAttack = true;
			ph.ChangeHealth(-10);
		}
		if (myTimmer > 1.5 && isAttack)
		{
			isAttack = false;
			GetComponent<Animation>().Play ("walk");
		}
	}
}
