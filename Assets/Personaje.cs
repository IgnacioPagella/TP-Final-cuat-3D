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
   public  int counter;
    public Text txtderrivos;
    public GameObject player;
    public Text txtgameOver;
    public GameObject camara;
    public Text txtMeta;

    int hasJump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        camara.SetActive(false);
        txtgameOver.enabled = (false);
        txtMeta.enabled = (false);
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
    void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.tag == "obstaculo")
        {
            counter++;
            txtderrivos.text = counter.ToString();
        }
        if (counter >=  3)
        {
            player.SetActive(false);
            txtTime.enabled = false;
            txtderrivos.enabled = false;
            txtgameOver.enabled = true;
            camara.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Meta")
        {
            player.SetActive(false);
            txtTime.enabled = false;
            txtMeta.enabled = true;
            txtderrivos.enabled = false;
            txtgameOver.enabled = false;
            camara.SetActive(true);
        }
    }
}
