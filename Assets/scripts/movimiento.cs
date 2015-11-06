using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

	void Start () {
		
	}
	

	// Update is called once per frame
	void Update () 
	{
		if ((Input.GetAxis ("Horizontal") >= 0.01f) || (Input.GetAxis ("Horizontal") <= 0.01f)) {
			gameObject.transform.Translate (new Vector3 (Input.GetAxis ("Horizontal"), 0.0f, 0.0f));
		}
		if ((Input.GetAxis ("Vertical") >= 0.01f) || (Input.GetAxis ("Vertical") <= 0.01f)) {
			gameObject.transform.Translate (new Vector3 (0.0f, 0.0f, Input.GetAxis ("Vertical")));
		}
		if (Input.GetButton("Jump")) Impulso();
		
	}
	
	void Impulso()
	{
		gameObject.GetComponent<Rigidbody>().AddForce(new Vector3 (0.0f, 0.2f, 0.0f), ForceMode.Impulse);
	}

}
