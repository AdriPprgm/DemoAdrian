using UnityEngine;

public class bulletscriptold : MonoBehaviour
{
    public float damage = 1;

    public playerhealth lives_of_player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player"){
            lives_of_player = collision.gameObject.GetComponent<playerhealth>();
            lives_of_player.get_hit(damage);
            Destroy(this.gameObject);
        }
        Destroy(this.gameObject);
    }
}
