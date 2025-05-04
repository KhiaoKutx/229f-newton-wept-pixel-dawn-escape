using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform posStart;
    public Transform posEnd;
    public float speed = 2f;
    public float waitTime = 2f;

    private Vector3 target;
    private bool facingRight = true;
    private float waitTimer;

    void Start()
    {
        target = posEnd.position;
        waitTimer = 0f;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target) < 0.05f)
        {
            waitTimer += Time.deltaTime;
            if (waitTimer >= waitTime)
            {
                target = (target == posStart.position) ? posEnd.position : posStart.position;
                Flip();
                waitTimer = 0f;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
 
}