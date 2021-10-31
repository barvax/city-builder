using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    private bool moveRight;
   // private Rigidbody2D rb;

    public Joystick joystick;
    void Start()
    {
      //  rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (true)
        {
              float translation = joystick.Vertical * speed;
             translation *= Time.deltaTime;
              transform.Translate(0, translation, 0);
          
        }
        
        float horizontal = joystick.Horizontal * speed;

        
       
        horizontal *= Time.deltaTime;

        
       

      
        transform.Translate(horizontal, 0, 0);
    }

    public void ZoomIn()
    {
        if (Camera.main.orthographicSize > 4)
        {
            Camera.main.orthographicSize -= 1;
        }
       
    }

    public void ZoomOut()
    {
        if (Camera.main.orthographicSize < 30)
        {
            Camera.main.orthographicSize += 1;
        }

    }
}
