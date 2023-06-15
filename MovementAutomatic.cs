using System;
using UnityEngine;

public class MovementAutomatic : MonoBehaviour 
{
    
    public enum TypeMovementBot { HorizontalBounce,VerticalBounce,HorizontalFromLeft, HorizontalFromRight,VerticalFromAbove, VerticalFromBelow }

    [SerializeField] TypeMovementBot typeMovementRobot;
    [SerializeField] float _speed = 0.04f;
    [SerializeField] float startX = 25.5F;
    [SerializeField] float startY = 5;
    [SerializeField] float endX = 28.6F;
    [SerializeField] float endY = 10;
    private Boolean goingRight = true;
    private Boolean goingDown = true;

    private Transform t;

    private void Awake()
    {
        t = GetComponent<Transform>();
    }

    private void start(){
        t.position = new Vector2(27, 4);
        typeMovementRobot = TypeMovementBot.HorizontalBounce;
    }

    private void FixedUpdate()
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
        if (t.position.x >= endY)
        {
            goingDown = false;
        }
        else if (t.position.x <= startY){
            goingDown = true;
        }
        if (goingDown){
            HorizontalFromLeft();
        } else {
            HorizontalFromRight();
        }
    }

    private void HorizontalFromLeft()
    {
        t.position = new Vector2(t.position.x + _speed, t.position.y);
    }

    private void HorizontalFromRight()
    {
        t.position = new Vector2(t.position.x - _speed, t.position.y);
    }

    private void VerticalFromBelow()
    {
        t.position = new Vector2(t.position.x, t.position.y + _speed);
    }

    private void VerticalFromAbove()
    {
        t.position = new Vector2(t.position.x, t.position.y - _speed);
    }
}
