using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    enum TypeMovementBot { HorizontalBounce,VerticalBounce,HorizontalFromLeft, HorizontalFromRight,VerticalFromAbove, VerticalFromBelow }

    [SerializeField] TypeMovementBot typeMovementRobot;

    public void speed = 1;

    private Transform t;

    private void Awake()
    {
        t = GetComponent<Transform>();
    }
    private void Update()
    {
        try
        {
            switch (typeMovementRobot)
            {
                case TypeMovementBot.HorizontalBounce:
                    break;
                case TypeMovementBot.VerticalBounce:
                    break;
                case TypeMovementBot.HorizontalFromLeft:
                    break;
                case TypeMovementBot.HorizontalFromRight:
                    break;
                case TypeMovementBot.VerticalFromAbove:
                    break;
                case TypeMovementBot.VerticalFromBelow:
                    break;
            }
        }catch(Exception e)
        {
            Debug.LogError("No se ha encontrado el componente Transform en el objeto actual");
        }
    }

    private void HorizontalBounce()
    {
        if (t.position.x >= 29)
        {
            t.position = new Vector3()
        }
    }

    private void VerticalBounce()
    {
        if (t.position.x <= 25)
        {
            t.position = new Vector3()
        }
    }

    private void HorizontalFromLeft()
    {
        if (Input.GetKeyDown(KeyCode.Left))
        {
            float direction = Input.GetAxis("Horizontal");
            t.Translate(Vector2.right * speed * direction * Time.deltaTime)
        }
        
    }

    private void HorizontalFromRight()
    {
        if (Input.GetKeyDown(KeyCode.Right))
        {
            float direction = Input.GetAxis("Horizontal");
            t.Translate(Vector2.right * speed * direction * Time.deltaTime)
        }
    }

    private void VerticalFromAbove()
    {
        if (Input.GetKeyDown(KeyCode.Down))
        {
            float direction = Input.GetAxis("Horizontal");
            t.Translate(Vector2.right * speed * direction * Time.deltaTime)
        }
    }

    private void VerticalFromBelow()
    {
        if (Input.GetKeyDown(KeyCode.Up))
        {
            float direction = Input.GetAxis("Horizontal");
            t.Translate(Vector2.right * speed * direction * Time.deltaTime)
        }
    }
}
