using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public float lives;

    public GameOverScreen gameOver;

    public float max_lives = 5f;

    public healthui healthbar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lives = max_lives;
        healthbar.Setmaxhp();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void get_hit(float amount)
    {
        lives -= amount;
        healthbar.Sethp(lives);

        if (lives <= 0){
            gameOver.Setup();
        }
    }
}