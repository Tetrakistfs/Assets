using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D bulletbody;
    public float bulletSpeed = 10f;

    void Start()
    {

    }
    void Update()
    {
        bulletbody.velocity = Vector2.right * bulletSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            Debug.Log("bullet Hit");
            enemyComponent.takeDamage(1);
        }
        Destroy(gameObject);
    }

}
