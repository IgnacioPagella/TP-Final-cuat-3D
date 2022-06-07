using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public Text txtTime;
    int counter;
    public Text derrivos;
   
    
    

    int hasJump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        float elapsedTime = Time.time;
       txtTime.text = Mathf.Floor(elapsedTime).ToString();
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
           
        }
        
    }
    //void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.name == "personaje")
    //    {
    //        counter++;
    //    }
    //}
}
