using UnityEngine;

public class bulletscript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            LivesPlayer.instance.vidas--;
            HUDController.instance.UpdateLives();
            Destroy(this.gameObject);
            if (LivesPlayer.instance.vidas <= 0)
            {
                HUDController.instance.GameOver();
            }
        }
        Destroy(this.gameObject);
    }
}