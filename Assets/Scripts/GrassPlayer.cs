using UnityEngine;
using UnityEngine.InputSystem;

public class GrassPlayer : Player
{
    public GameObject bulletPrehab;

    protected override void Attack()
    {
        Instantiate(bulletPrehab, transform.position, Quaternion.identity);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.tag == "Fire")
        {
            Destroy(gameObject);
        }
    }
}
