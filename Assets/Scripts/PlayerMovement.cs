using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float walkingSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WalkHandler();
    }

    void WalkHandler()
    {
        //input on x (horiz)
        float hAxis = Input.GetAxis("Horizontal");


        //input on y (vert)
        float vAxis = Input.GetAxis("Vertical");

        //Movement vector
        Vector3 movement = new Vector3(hAxis * walkingSpeed * Time.deltaTime, vAxis * walkingSpeed * Time.deltaTime, 0);

        //Calculate new position
        transform.position = transform.position + movement;

    }
}
