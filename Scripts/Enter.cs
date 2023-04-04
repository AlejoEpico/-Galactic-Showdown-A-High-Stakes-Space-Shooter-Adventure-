using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetButtonDown("Fire1"))
        // transform.Translate(1,0,0);
       transform.Translate(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
    }
}
