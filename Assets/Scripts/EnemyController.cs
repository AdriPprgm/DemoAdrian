using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject, 0.2f);
        }
    }
}
