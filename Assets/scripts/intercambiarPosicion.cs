using UnityEngine;
using System.Collections;

public class intercambiarPosicion : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Jump")) {
			Vector3 temporal = transform.position;
			temporal = target.transform.position;
			target.transform.position = gameObject.transform.position;
			gameObject.transform.position = temporal;
		}
	}
}
