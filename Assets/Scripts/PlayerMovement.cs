using UnityEngine;
using UnityEngine.InputSystem; //use all the things relevant to the new Input System

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 5f;
    private Vector2 movementDir = Vector2.zero; //physics =D

    Animator anim;

    void Start()
    {
        Debug.Log("PlayerMovement script initialized.");
        anim = GetComponent<Animator>();
    }

    public void OnMove(InputValue inputValue)
    {
        movementDir = inputValue.Get<Vector2>(); //on move, get the vector2 associated w the player. e.g. if player presses up, change the moveDir to reflect that
        
    }

    void FixedUpdate()
    {
        //update vector to reflect the movement direction
        Vector2 move = new Vector2(movementDir.x, movementDir.y);
        rb.linearVelocity = move * moveSpeed;
        anim.SetFloat("xVelocity", rb.linearVelocity.x);
        anim.SetFloat("yVelocity", rb.linearVelocity.y);
        //Debug.Log(rb.rb.linearVelocity.x);
    }
}
