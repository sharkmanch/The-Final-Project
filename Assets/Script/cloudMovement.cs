using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMovement : MonoBehaviour {
	public float xOffsetLo;
	public float xOffsetHi;
	public float xxx;
	public float yyy;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = new Vector3 (1 * Random.Range (5, 15), 0, 0);
		transform.position = new Vector3 (Random.Range (-xxx, yyy), transform.position.x);
	}

	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag =="Respawner"){
			transform.position = new Vector3 (0,Random.Range(-xxx, yyy));
				transform.position += new Vector3 (Random.Range(xOffsetLo, xOffsetHi),0);
				GetComponent<Rigidbody2D>().velocity = new Vector3 (1*Random.Range(5,15),0,0);
}
				}
				}