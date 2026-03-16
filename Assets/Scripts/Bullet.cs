using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15.0f;
    private Vector2 direction = Vector2.right;
    private Vector2 velocity;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        velocity = speed * direction * Time.deltaTime;
        transform.Translate(velocity);
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
