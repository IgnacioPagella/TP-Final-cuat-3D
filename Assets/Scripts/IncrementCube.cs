using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementCube : MonoBehaviour
{
    bool Comprobante;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Comprobante)
        {
            transform.localScale += new Vector3(0, 0.05f, 0);
            if(transform.localScale.y > 4)
            {
                Comprobante = false;
            }
        }
        if(Comprobante == false)
        {
            transform.localScale -= new Vector3(0, 0.05f, 0);
            if (transform.localScale.y < 0.8f)
            {
                Comprobante = true;
            }
        }
        
    }
}
