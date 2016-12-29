using UnityEngine;
using System.Collections;

public class TriggerRespawn : MonoBehaviour {
	public float yOffsetHi;
	public float yOffsetLo;

	void Start(){
		GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, -1* Random.Range (5, 15), 0);
		transform.position = new Vector3 (Random.Range (-10f, 10f), transform.position.y);
	}


	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Respawner") {

			transform.position = new Vector3 (Random.Range (-10f, 10f), 0);
			transform.position += new Vector3 (0, Random.Range (yOffsetLo, yOffsetHi));
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, -1 * Random.Range (5, 15), 0);
		}


	}

}
