using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;

    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode moveRight = KeyCode.RightArrow;


    Camera mainCamera;
    Vector3 RightDownBoundaries;
    Vector3 LeftDownBoundaries;

    void Start () {
        mainCamera = Camera.main;

        LeftDownBoundaries = mainCamera.transform.GetChild(0).position;
        RightDownBoundaries = mainCamera.transform.GetChild(1).position;
    }

  	void Update () {
        if(Input.GetKey(moveLeft))
        {
            transform.position -= new Vector3(movementSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(moveRight))
        {
            transform.position += new Vector3(movementSpeed * Time.deltaTime, 0);
        }

        if(transform.position.x >= RightDownBoundaries.x)
        {
            transform.position = new Vector3(RightDownBoundaries.x,transform.position.y);
        }

        if (transform.position.x <= LeftDownBoundaries.x)
        {
            transform.position = new Vector3(LeftDownBoundaries.x, transform.position.y);
        }
    }
}
