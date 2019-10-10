using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviourPunCallbacks
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
		/*if (PhotonNetwork.IsConnected)
		{
			if (!GetComponent<PhotonView>().IsMine) return;
		}*/

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * velocityMultiplier);
		if (rb.velocity.magnitude < 0.001)
		{
			rb.velocity = Vector3.zero;
		}
    }
}
