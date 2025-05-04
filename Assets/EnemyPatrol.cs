using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;                // ความเร็วในการเดิน
    public float patrolDistance = 3f;       // ระยะทางที่เดินได้ก่อนกลับทิศ

    private Vector3 initialPosition;        // ตำแหน่งเริ่มต้น
    private bool movingRight = true;        // ทิศทางการเดิน

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= initialPosition.x + patrolDistance)
                movingRight = false;
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= initialPosition.x - patrolDistance)
                movingRight = true;
        }
    }
}