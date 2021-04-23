using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D myRigid;
    public float flapStrength;
    public GameControl myGame;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigid.velocity = Vector2.up * flapStrength;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        myGame.GameOver();
    }

}
