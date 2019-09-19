using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteMovesToSphere : MonoBehaviour
{
    private Transform my_t;

    public GameObject player_sphere;
    private Transform sphere_t;

    // Start is called before the first frame update
    void Start()
    {
        my_t = GetComponent<Transform>();

        sphere_t = player_sphere.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        my_t.position = sphere_t.position;
    }
}
