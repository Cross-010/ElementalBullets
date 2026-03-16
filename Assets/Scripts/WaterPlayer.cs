using UnityEngine;
using UnityEngine.InputSystem;

public class WaterPlayer : Player
{
    public Bullet bulletPrehab;

    protected override void Attack()
    {
        Bullet newBullet = Instantiate(bulletPrehab, transform.position, Quaternion.identity);
        newBullet.SetDirection(Vector2.left);
    }
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        if (collision.tag == "Grass")
        {
            Destroy(gameObject);
        }
    }
}
