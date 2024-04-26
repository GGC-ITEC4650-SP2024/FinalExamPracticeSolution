using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    Renderer myRend;
    Collider myCol;
    ParticleSystem myPar;

    // Start is called before the first frame update
    void Start()
    {
        myRend = GetComponent<Renderer>();
        myPar = GetComponent<ParticleSystem>();
        myCol = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        myCol.enabled = false;
        myRend.enabled = false;
        myPar.Play();
    }
}
