using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreArea : MonoBehaviour
{

    public GameObject effectObject;
    public static int score;

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Ball>() != null)
        {
            effectObject.SetActive(true);
            score++;
            Debug.Log(score);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        effectObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
