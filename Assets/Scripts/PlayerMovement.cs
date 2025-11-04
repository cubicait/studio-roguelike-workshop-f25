using UnityEngine;
using UnityEngine.InputSystem; //use all the things relevant to the new Input System

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5f;
    Vector2 movementDir = Vector2.zero; //physics =D

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnMove(InputValue inputValue)
    {
        movementDir = inputValue.Get<Vector2>(); //on move, get the vector2 associated w the player. e.g. if player presses up, change the moveDir to reflect that
        //Debug.Log(movementDir);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        //update vector to reflect the movement direction
        Vector2 move = new Vector2(movementDir.x, movementDir.y);
        transform.position += (Vector3)move * moveSpeed * Time.fixedDeltaTime; //moving a position within a gameobject
    }
}
