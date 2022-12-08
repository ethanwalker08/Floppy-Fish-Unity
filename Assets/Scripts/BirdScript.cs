using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float rigitBodyInitialRotation;
    // Start is called before the first frame update
    void Start()
    {
        rigitBodyInitialRotation = myRigidBody.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {   
            myRigidBody.velocity = Vector2.up * flapStrength;
            myRigidBody.rotation = rigitBodyInitialRotation + 20;
        }
        myRigidBody.rotation -= 0.035f;

        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.gameOver();
    }
}
