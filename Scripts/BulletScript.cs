using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    public BirdScript bird;
    public float spawnRate = 0.5f;

    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
        spwanBullet();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spwanBullet();
            // Debug.Log("bullet");
            timer = 0;
        }
    }

    void spwanBullet()
    {
        Vector3 bulletPosition = bird.transform.position;
        Debug.Log(bulletPosition);
        Instantiate(bullet, bulletPosition + 2 * Vector3.right, bird.transform.rotation);
    }
}
