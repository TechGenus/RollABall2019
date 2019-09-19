using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody rb;
    public float velocityMultiplier = 1f;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * velocityMultiplier);
    }
}
