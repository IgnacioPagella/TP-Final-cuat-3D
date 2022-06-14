using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Personaje : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public Text txtTime;
    public int counter;
    public Text txtderrivos;
    public GameObject player;
    public Text txtgameOver;
    public GameObject camara;
    public Text txtMeta;
    public GameObject objectToClone;
    public int Contador;
    

    bool hasJump;
    Rigidbody rb;
    float elapsedTime; 

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
       
        elapsedTime = Time.timeSinceLevelLoad; ;
        txtTime.text = Mathf.Floor(elapsedTime).ToString();

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, movementSpeed);
         
            
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -movementSpeed);
           
          
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotationSpeed, 0);
          
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotationSpeed, 0);
          
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump = false;
        }
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "ground")
        {
            hasJump = true;
        }

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
            //Instantiate(objectToClone);
            ResetScene();
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
            while (Contador < 10)
            {
                Instantiate(objectToClone);
                objectToClone.transform.position = new Vector3(0, 50, 0);
                Contador++;
            }

        }

    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 

}
