using UnityEngine;

public class WaterBullet : Bullet
{   
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        if (collision.tag == "Fire")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.tag == "Grass")
        {
            Destroy(gameObject);
        }
    }
}
