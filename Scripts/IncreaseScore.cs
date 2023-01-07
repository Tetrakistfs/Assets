using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    public LogicScript score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collsion)
    {
        if (collsion.gameObject.layer == 3)
            score.changeScore(1);
    }
}
