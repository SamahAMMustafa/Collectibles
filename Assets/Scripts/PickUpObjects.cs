using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjects : MonoBehaviour
{
	//players collider
	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			//show in term that object collected
			print("Collected");
			//remove object from screen
			Destroy(gameObject);
		}
	}
}
