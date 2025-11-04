using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public void OnClick(InputValue value)
    {
        if (value.isPressed)
        {
            //converts where you clicked on screen to a world position
            Vector3 mouseScreenPos = Mouse.current.position.ReadValue();
            Vector3 mouseWorldPos = GetComponent<Camera>().ScreenToWorldPoint(mouseScreenPos + new Vector3(0, 0, GetComponent<Camera>().nearClipPlane));

            //Debug.Log(mouseWorldPos);

            Vector2 dir = new Vector2(mouseWorldPos.x - transform.position.x, mouseWorldPos.y - transform.position.y);
            dir.Normalize();

            GetComponent<Weapon>().Shoot(dir);
        }   
    }
}