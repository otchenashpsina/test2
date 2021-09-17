using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class test : MonoBehaviour
{
    private Vector2 movedirection;
    private float speed;
    public void OnMove(InputAction.CallbackContext context)
    {
        movedirection = context.ReadValue<Vector2>();
        Move(movedirection);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void Move(Vector2 direction)
    {
        float scaleMOveSpeed = speed * Time.deltaTime;
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
        transform.position += moveDirection * scaleMOveSpeed;
    }
}
