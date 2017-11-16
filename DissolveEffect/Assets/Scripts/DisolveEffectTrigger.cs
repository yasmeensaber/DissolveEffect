using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisolveEffectTrigger : MonoBehaviour {

	public Material disolveMatrial;
	public float speed,max;
	private float currentY, startTime;
	private void Update()
	{
		if (currentY < max) {
			disolveMatrial.SetFloat ("_DisolveY",currentY);
			currentY += Time.deltaTime * speed;

		}
		if (Input.GetKeyDown (KeyCode.E)) {
			TriggerEffect ();
		}
	}
	private void TriggerEffect ()
	{
		startTime = Time.time;
		currentY = 0;
	}
}
