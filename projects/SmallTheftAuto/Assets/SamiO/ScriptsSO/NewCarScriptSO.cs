using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCarScriptSO : MonoBehaviour
{
    
    public float driftFactor = 0.95f;
    public float accelerationForce = 30.0f;
    public float turnFactor = 3.5f;
    public float maxSpeed = 20;
    public float brakeStrengt;

    private float accelerationInput = 0;
    private float sterringInput = 0;
    private float velocityVsUp = 0;

    private float rotationAngle = 0;

    private Rigidbody2D carBody2D;
    void Awake()
    {
        carBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ApplyForce();
        ApplySterring();
        KillVelocity();
        
    }

    void ApplyForce()
    {
        velocityVsUp = Vector2.Dot(transform.up, carBody2D.velocity);
        
        if (velocityVsUp > maxSpeed && accelerationInput > 0)
            return;
        
        if (velocityVsUp < -maxSpeed * 0.5f && accelerationInput < 0)
            return;

        if (carBody2D.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
            return;
        
        
        if (accelerationInput == 0)
            carBody2D.drag = Mathf.Lerp(carBody2D.drag, 3.0f, Time.fixedDeltaTime * 3);
        else
        {
            carBody2D.drag = 0f;
        }
        
        Vector2 forceVector = transform.up * accelerationInput * accelerationForce;
        carBody2D.AddForce(forceVector, ForceMode2D.Force);

    }

    void ApplySterring()
    {

        float minSpeedAllowTurn = (carBody2D.velocity.magnitude / 8);
        minSpeedAllowTurn = Mathf.Clamp01(minSpeedAllowTurn);
        
        rotationAngle -= sterringInput * turnFactor * minSpeedAllowTurn;
        carBody2D.MoveRotation(rotationAngle);

    }

    public void SetInputVector(Vector2 inputVector)
    {
        sterringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }


    void KillVelocity()
    {
        Vector2 forwardVelocity = transform.up * Vector2.Dot(carBody2D.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(carBody2D.velocity, transform.right);
       
        carBody2D.velocity = forwardVelocity + rightVelocity * driftFactor;

    }
}
