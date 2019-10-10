using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteMovesToSphere : MonoBehaviour
{
	private Animator anim;
	private int previous_walk_state;

	private Transform my_t;

    public GameObject player_sphere;
    private Transform sphere_t;

    // Start is called before the first frame update
    void Start()
    {
		anim = GetComponent<Animator>();
        my_t = GetComponent<Transform>();

        sphere_t = player_sphere.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
		DoWalkingAnimation();
		
        my_t.position = sphere_t.position;
    }

	void DoWalkingAnimation()
	{
		// player movement input
		float hAxis = Input.GetAxis("Horizontal");
		float vAxis = Input.GetAxis("Vertical");

		if (hAxis < 0)
		{
			anim.SetInteger("walk_state", -1);
			previous_walk_state = -1;
		}
		else if (hAxis > 0)
		{
			anim.SetInteger("walk_state", 1);
			previous_walk_state = 1;
		}
		else if (hAxis == 0 && vAxis != 0)
		{
			anim.SetInteger("walk_state", previous_walk_state);
		}
		else
		{
			anim.SetInteger("walk_state", 0);
		}
	}
}
