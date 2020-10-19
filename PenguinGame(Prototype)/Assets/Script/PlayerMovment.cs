using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovment : MonoBehaviour
{
    public float speed=10f;
    float xmov, ymov;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movemnt();
    }
    void Movemnt()
    {
        xmov = Input.GetAxis("Horizontal");
        ymov = Input.GetAxis("Vertical");
       
        Vector2 move = new Vector2(xmov, ymov);
        move.Normalize();
        rb.velocity = move * speed * Time.deltaTime;
     
    }
   
}
