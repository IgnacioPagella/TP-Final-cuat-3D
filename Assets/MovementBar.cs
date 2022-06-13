using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBar : MonoBehaviour
{
    bool Comprobante;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Comprobante = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Comprobante)
        {
            transform.position -= new Vector3(speed, 0, 0);
            if(transform.position.x <=(-32))
            {
                Comprobante = false;
            }
        }
        if (Comprobante == false)
        {
            transform.position += new Vector3(speed, 0, 0);
            if (transform.position.x >= (-20))
            {
                Comprobante = true;

            }
        }
        
    }
}
