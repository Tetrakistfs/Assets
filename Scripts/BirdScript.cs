using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public LogicScript logic;
    public float scale = 10;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        birdBody.freezeRotation = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        birdBody.velocity = Vector2.up * scale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdBody.velocity = Vector2.up * scale;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.gameOver();
    }

}
