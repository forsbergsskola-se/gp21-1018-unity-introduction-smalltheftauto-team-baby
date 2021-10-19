using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveSO : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    

    public Camera cam;
    private Vector2 mousePos;

    private Vector2 moveDiraction;

    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical"); 
        

        moveDiraction = new Vector2(movement.x, movement.y).normalized;

        mousePos =cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90;
        rb.rotation = angle;
    }
}
