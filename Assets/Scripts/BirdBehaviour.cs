using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour


{
    private Rigidbody2D rbBird;
    private float fUp = 200f;
    public bool dead;

    // Start is called before the first frame update
    void Start()
    {
        rbBird = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dead) return;

        if (Input.GetKeyDown("space")) 
        {
            rbBird.velocity = Vector2.zero;
            rbBird.AddForce(Vector2.up * fUp);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
        Destroy(gameObject);
        Debug.Log("Dead");
    }
}
