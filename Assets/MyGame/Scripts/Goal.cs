using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	// A static field visible from anywhere
	public static bool goalMet = false;
	public ParticleSystem splat;

	void OnCollisionEnter(Collision col) {
		// Check if the hit comes from a projectile
		if(col.gameObject.tag == "Projectile") {
			goalMet = true;
			Debug.Log ("goalMet by Projectile");

			GameObject.FindWithTag("Sound").GetComponent<AudioSource>().Play();

			Destroy(gameObject);
			splat.Play();

			// Set alpha to higher opacity
			Color c = GetComponent<Renderer>().material.color;
			c.a = 1.0f;
			GetComponent<Renderer>().material.color = c;
		}
		if(col.gameObject.tag == "Plank") {
			goalMet = true;

			GameObject.FindWithTag("DieSound").GetComponent<AudioSource>().Play();


			// Set alpha to higher opacity
			Color c = GetComponent<Renderer>().material.color;
			c.a = 1.0f;
			GetComponent<Renderer>().material.color = c;

			Destroy(gameObject);
			splat.Play();

		}
	}
}
