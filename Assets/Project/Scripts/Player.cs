using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour

{

    public Ball ball;
    public GameObject playerCamera;

    public float ballDistance = 2f;
    public float ballThrowingForce = 520f;

    public bool holdingBall = true;

    public float distanceToHoop = 0;
    GameObject hoopPosition;

    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;
        playerCamera.transform.position = new Vector3(Random.Range(-3, 3), 2, Random.Range(-3, 3));
        hoopPosition = GameObject.Find("ScoreArea");
        distanceToHoop = Vector3.Distance(playerCamera.transform.position, hoopPosition.transform.position);
        ballThrowingForce = (290 + (distanceToHoop * 70 / 3));
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        { 
            ball.transform.position = playerCamera.transform.position + (playerCamera.transform.forward * ballDistance);

            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                ball.ActivateTrail();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
            }
        
        }
        
        
    }
}
