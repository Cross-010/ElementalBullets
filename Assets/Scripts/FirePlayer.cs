using UnityEngine;
using UnityEngine.InputSystem;

public class FirePlayer : Player
{
    public Bullet bulletPrehab;

    protected override void Attack()
    {
        Bullet newBullet = Instantiate(bulletPrehab, transform.position, Quaternion.identity);
        newBullet.SetDirection(lastDirection);
    }
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.tag == "Water")
        {
            Destroy(gameObject);
        }
    }
}
