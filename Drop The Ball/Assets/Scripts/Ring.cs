using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;

    public static int Combo = 1;


    private GameManager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y + 13.3F >= ball.position.y)
        {
            Destroy(gameObject);
            gm.GameScore(25);
            gm.BreakRingScore(1);
            Combo = + 1;
           
        }

    }
  

}
