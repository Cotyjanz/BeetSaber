using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beets : MonoBehaviour {

	private float timer = 0;

	
	// Update is called once per frame
	void Update () {
			timer += Time.deltaTime;

			if (timer > 7f) {
				Object.Destroy(this.gameObject);
			} else {
			//forward states a direction of +Z, forward * -1 for -Z
			transform.position += Time.deltaTime * (transform.forward * -1) * 2;

			}


	}
}
