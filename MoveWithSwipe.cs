using System;
using UnityEngine;

public class MoveWithSwipe : MonoBehaviour
{

    [SerializeField] float speed = 0.05F;
    [SerializeField] float minX = 25.5F;
    [SerializeField] float startY = 5;
    [SerializeField] float maxX = 28.6F;
    private Boolean goingRight = true;

    private Transform t;

    private void Awake()
    {
        t = GetComponent<Transform>();
    }

    private void Start(){
        t.position = new Vector2(27, 4);
    }

    private void Update()
    {
        try
        {
            switch (typeMovementRobot)
            {
                case TypeMovementBot.Left:
                    Left();
                    break;
                case TypeMovementBot.Right:
                    Right();
                    break;
            }
        }catch
        {
            Debug.LogError("No se ha encontrado el componente Transform en el objeto actual");
        }
    }


    private void Left()
    {
        t.position = new Vector2(t.position.x + speed, t.position.y);
    }

    private void Right()
    {
        t.position = new Vector2(t.position.x - speed, t.position.y);
    }
}
