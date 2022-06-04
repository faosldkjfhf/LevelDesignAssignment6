using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 5f;
    private Vector2 playerVelocity = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProcessMove(Vector2 input) {
        Vector2 direction = Vector2.zero;
        direction.x = input.x;
        direction.y = input.y;

        controller.Move(transform.TransformDirection(direction) * speed * Time.deltaTime);
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
