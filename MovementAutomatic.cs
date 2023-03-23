using System;
using UnityEngine;

public class MovementAutomatic : MonoBehaviour
{
    enum TypeMovementBot { HorizontalBounce,VerticalBounce,HorizontalFromLeft, HorizontalFromRight,VerticalFromAbove, VerticalFromBelow }

    [SerializeField] TypeMovementBot typeMovementRobot;
    [SerializeField] float speed = 1;
    [SerializeField] float startX = 25;
    [SerializeField] float startY = 3;
    [SerializeField] float endX = 29;
    [SerializeField] float endY = 10;

    private Transform t;

    private void Awake()
    {
        t = GetComponent<Transform>();
    }

    private void Start(){
        if(typeMovementRobot == TypeMovementBot.HorizontalBounce || typeMovementRobot == TypeMovementBot.HorizontalFromLeft || typeMovementRobot == TypeMovementBot.HorizontalFromRight) {
            t.position = new Vector2(startX, t.position.y);
        } else {
            t.position = new Vector2(t.position.x, startY);
        }
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
            HorizontalFromRight();
        }
        else if (t.position.x <= startX){
            HorizontalFromLeft();
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
        t.position = new Vector2(t.position.x + speed, t.position.y);
    }

    private void HorizontalFromRight()
    {
        t.position = new Vector2(t.position.x - speed, t.position.y);
    }

    private void VerticalFromAbove()
    {
        t.position = new Vector2(t.position.x, t.position.y + speed);
    }

    private void VerticalFromBelow()
    {
        t.position = new Vector2(t.position.x, t.position.y - speed);
    }
}
