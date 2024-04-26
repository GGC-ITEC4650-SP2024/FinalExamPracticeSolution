using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    Rigidbody myBod;
    public AudioClip bounceSound;
    AudioSource myAudio;
    int numBlocks;

    Text goMsg;

    void Start()
    {
        myBod = GetComponent<Rigidbody>();
        Vector3 dir = new Vector3(Random.Range(-5, 5), 1, 0);
        myBod.velocity = dir.normalized * 20;
        myAudio = GetComponent<AudioSource>();
        goMsg = GameObject.Find("GameOverMsg").GetComponent<Text>(); 
        numBlocks = GameObject.FindGameObjectsWithTag("Block").Length;   
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject g = collision.gameObject;
        myAudio.PlayOneShot(bounceSound);
        if(g.name == "BottomWall") {
            myBod.constraints = RigidbodyConstraints.FreezeAll;
            goMsg.text = "You Lose!";
        }
        else if(g.tag == "Block") {
            numBlocks--;
            if(numBlocks <= 0) {
                myBod.constraints = RigidbodyConstraints.FreezeAll;
                goMsg.text = "You Win!";
            }
        }
    }
}
