using System.Drawing;
using Unity.Mathematics;
using UnityEngine;

public class TurretFollow : MonoBehaviour
{
    public Transform Target;

    Vector2 Direction;

    public GameObject turret;

    public GameObject bullet;

    public float FireRate;

    public Transform pointoffire;

    float timetofire = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = Target.position;

        Direction = targetPos - (Vector2)transform.position;

        RaycastHit2D rayinfo = Physics2D.Raycast(transform.position,Direction);

        if (rayinfo){
            if (rayinfo.collider.gameObject.tag == "Player"){
                turret.transform.up = Direction;
                if (Time.time > timetofire){
                    timetofire = (Time.time + 1)/FireRate;
                    shoot();
                }
            }
        }
    }

    void shoot(){
        GameObject BulletInstance = Instantiate(bullet,pointoffire.position,Quaternion.identity);
        BulletInstance.GetComponent<Rigidbody2D>().AddForce(Direction * 100);
    }
}
