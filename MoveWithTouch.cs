using System;
using UnityEngine;

public class MoveWithTouch : MonoBehaviour
{

    [SerializeField] float step = 1.8F;
    [SerializeField] float minX = 25.5F;
    [SerializeField] float startY = 5;
    [SerializeField] float maxX = 28.6F;

    private Transform t;

    private void Awake()
    {
        t = GetComponent<Transform>();
    }

    private void Start(){
        t.position = new Vector2(27, startY);
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < Screen.width / 2 && t.position.x < maxX)
                {
                    t.position = new Vector2(t.position.x - step, t.position.y);
                }
                if (touch.position.x > Screen.width / 2 && t.position.x > minX)
                {
                    t.position = new Vector2(t.position.x + step, t.position.y);
                }
            }
            // try
            // {
            //     switch (typeMovementRobot)
            //     {
            //         case TypeMovementBot.Left:
            //             Left();
            //             break;
            //         case TypeMovementBot.Right:
            //             Right();
            //             break;
            //     }
            // }catch
            // {
            //     Debug.LogError("No se ha encontrado el componente Transform en el objeto actual");
            // }
        }
    }


    // private void Left()
    // {
    //     t.position = new Vector2(t.position.x + speed, t.position.y);
    // }

    // private void Right()
    // {
    //     t.position = new Vector2(t.position.x - speed, t.position.y);
    // }
}
