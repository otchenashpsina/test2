using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class test2 : MonoBehaviour
{
    private PlayerInput input;
    public GameObject player;
    public static float speed;
    public float spawnspeed;
    private void Awake()
    {
        input = new PlayerInput();
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = spawnspeed;
        

    }
    private void OnEnable()
    {
        input.Enable();
    }
    private void OnDisable()
    {
        input.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.shiftKey.isPressed)
        {
            speed += 0.5f;
        }
        else
        {
            speed = spawnspeed;
            
        }
        Vector2 direction = input.Player.Movement.ReadValue<Vector2>() * speed;
        player.GetComponent<Rigidbody2D>().velocity = direction;
    }
}
