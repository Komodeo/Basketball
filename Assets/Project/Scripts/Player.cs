using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{

    public GameObject ball;
    public GameObject playerCamera;

    public float ballDistance = 2f;

    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        ball.transform.position = playerCamera.transform.position + (playerCamera.transform.forward * ballDistance);
    }
}
