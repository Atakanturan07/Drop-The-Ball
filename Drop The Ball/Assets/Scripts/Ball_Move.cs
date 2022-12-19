using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashprefab;
    private GameManager gm;


    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }
    void Update()
    {

    }
    private void OnCollisionEnter(Collision Other)
    {

        rb.velocity = Vector3.up * jumpForce;

        GameObject splash = Instantiate(splashprefab, transform.position + new Vector3(0f, -0.2f, 0f), transform.rotation);

        splash.transform.SetParent(Other.gameObject.transform);

        string matarialName = Other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Materyal Adý " + matarialName);

        if (gm.BreakRing < 3)
        {
            if (matarialName == "UnSafeColor (Instance)")
            {
                gm.RestartGame();
                Ring.Combo = 1;
                gm.BreakRing = 0;
            }
            else if (matarialName == "Safe Color (Instance)")
            {
                gm.BreakRing = 0;
                Ring.Combo = 1;
            }
           
        }
       

        else if (matarialName == "Last Ring (Instance)")
        {
            Debug.Log("geçtin");

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gm.BreakRing >= 4)
        {
            if (other.CompareTag("Ring"))
            {
                Debug.Log("DENEME01");
                Destroy(other.gameObject);
                gm.BreakRing = 0;
                gm.GameScore(25);
                Ring.Combo = 1;


            }
        }
    }
}

    

