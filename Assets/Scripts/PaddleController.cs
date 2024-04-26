using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position + 
            Vector3.right * Input.GetAxis("Horizontal") * 15 * Time.deltaTime;
        if(temp.x > -15.5f && temp.x < 15.5f)
        {
            transform.position = temp;
        }
    }
}
