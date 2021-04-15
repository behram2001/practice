using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    float a;
    float b;
    public int speed = 50;
    private Rigidbody2D rigidbody2D;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float mov = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", mov * speed);
        rigidbody2D.velocity = new Vector3(mov * speed, rigidbody2D.velocity.y, 0);
        if(Input.GetKey(KeyCode.Space))
        {
            rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x,speed, 0);
        }




         a = Input.GetAxis("Horizontal");
        transform.Translate(Input.GetAxis("Horizontal") * 15f * Time.deltaTime, 0f, 0f);
        Vector3 character = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
             animator.SetFloat("Speed", mov * speed);
        rigidbody2D.velocity = new Vector3(mov * speed, rigidbody2D.velocity.y, 0);
            character.x = 10;
        }
       

        b = Input.GetAxis("Vertical");
        transform.Translate(0f, Input.GetAxis("Vertical") * 15f * Time.deltaTime, 0f);
        Vector3 character2 = transform.localScale;
        if (Input.GetAxis("Vertical") > 0)
        {
            character2.x = 10;
        }
        
        
        
    }
        
    
}


  

 