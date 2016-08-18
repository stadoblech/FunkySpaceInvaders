using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public float movementSpeed;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0,movementSpeed*Time.deltaTime); 	
	}
}
