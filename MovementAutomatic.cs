using System;
using UnityEngine;

public class MovementAutomatic : MonoBehaviour 
{
    public MovementAutomatic (TypeMovementBot type_, float speed_){
        Type = type_;
        Speed = speed_;
    }

    public TypeMovementBot Type { get; set; }
    public float Speed { get;set; }
    
    public enum TypeMovementBot { HorizontalBounce,VerticalBounce,HorizontalFromLeft, HorizontalFromRight,VerticalFromAbove, VerticalFromBelow }

    [SerializeField] TypeMovementBot typeMovementRobot;
    [SerializeField] float startX = 25.5F;
    [SerializeField] float startY = 5;
    [SerializeField] float endX = 28.6F;
    [SerializeField] float endY = 10;
    private Boolean goingRight = true;

    private Transform t;

    private void Awake()
    {
        t = GetComponent<Transform>();
    }

    private void start(){
        t.position = new Vector2(27, 4);
        typeMovementRobot = Type;
    }

    private void Update()
    {
        try
        {
            switch (typeMovementRobot)
            {
                case TypeMovementBot.HorizontalBounce:
                    HorizontalBounce();
                    break;
                case TypeMovementBot.VerticalBounce:
                    VerticalBounce();
                    break;
                case TypeMovementBot.HorizontalFromLeft:
                    HorizontalFromLeft();
                    break;
                case TypeMovementBot.HorizontalFromRight:
                    HorizontalFromRight();
                    break;
                case TypeMovementBot.VerticalFromAbove:
                    VerticalFromAbove();
                    break;
                case TypeMovementBot.VerticalFromBelow:
                    VerticalFromBelow();
                    break;
            }
        }catch
        {
            Debug.LogError("No se ha encontrado el componente Transform en el objeto actual");
        }
    }

    private void HorizontalBounce()
    {
        if (t.position.x >= endX)
        {
            goingRight = false;
        }
        else if (t.position.x <= startX){
            goingRight = true;
        }
        if (goingRight){
            HorizontalFromLeft();
        } else {
            HorizontalFromRight();
        }
    }

    private void VerticalBounce()
    {
        if (t.position.y >= endY)
        {
            VerticalFromBelow();
        }
        else if (t.position.y <= startY){
            VerticalFromAbove();
        }
    }

    private void HorizontalFromLeft()
    {
        t.position = new Vector2(t.position.x + Speed, t.position.y);
    }

    private void HorizontalFromRight()
    {
        t.position = new Vector2(t.position.x - Speed, t.position.y);
    }

    private void VerticalFromBelow()
    {
        t.position = new Vector2(t.position.x, t.position.y + Speed);
    }

    private void VerticalFromAbove()
    {
        t.position = new Vector2(t.position.x, t.position.y - Speed);
    }
}
