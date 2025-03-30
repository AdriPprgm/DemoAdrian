using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pmovement2 : MonoBehaviour
{
    [SerializeField]

    private InputAction moveAction;

    [SerializeField]

    private InputAction jumpAction;

    [SerializeField]

    private InputAction crouchAction;
    
    private Animator animationhandler;
    
    private float Speed = 7.5f;

    private float jump_power = 1.5f;

    private Rigidbody2D body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
        jumpAction.Enable();
        crouchAction.Enable();
        body = GetComponent<Rigidbody2D>();
        animationhandler = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D rayinfo = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        bool IsGrounded(){

            if(rayinfo && rayinfo.collider.gameObject.tag == "Ground"){
                return true;
            }
            else{
                return false;
            }
        }

        if (!IsGrounded()){
            jumpAction.Disable();
        }
        else{
            jumpAction.Enable();
        }

        Vector2 move = moveAction.ReadValue<Vector2>();
        transform.position = (Vector2)transform.position + move * Speed * Time.deltaTime;

        float jump = jumpAction.ReadValue<float>();
        
        if (jump > 0){
            body.AddForceY(jump_power * Speed);
        }

        body.linearVelocityX = 0;

        animationhandler.SetFloat("Speed",body.linearVelocityX);
        
    }
}
