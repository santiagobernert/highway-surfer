using System;
using UnityEngine;

public class MoveWithTouch : MonoBehaviour
{

    [SerializeField] float speed = 0.05F;
    [SerializeField] float minX = 25.5F;
    [SerializeField] float startY = 5;
    [SerializeField] float maxX = 28.6F;
    [SerializeField] int lane;
    [SerializeField] float[] lanes = {25.2F, 26.9F, 28.6F};

    private Transform t;

    private void Awake()
    {
        t = GetComponent<Transform>();
    }

    private void Start(){
        t.position = new Vector2(26.9F, startY);
        lane = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            lane = lane-1;
            Debug.Log(lane);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            lane = lane+1;
            Debug.Log(lane);
        }
        if (t.position.x < lanes[lane])
        {
            t.position = new Vector2(t.position.x + speed, t.position.y);
        }else if(t.position.x > lanes[lane]){
            t.position = new Vector2(t.position.x - speed, t.position.y);
        }


        // if (Input.touchCount > 0)
        // {
            // Touch touch = Input.GetTouch(0);
            // if (touch.phase == TouchPhase.Began)

            // {
                // if (touch.position.x < Screen.width / 2 && t.position.x < maxX)
                // {
                //     lane = lane--;
                //     Debug.Log("izquierda");
                // }
                // if (touch.position.x > Screen.width / 2 && t.position.x > minX)
                // {
                //     lane = lane ++;
                //     Debug.Log("derecha");
                // }
                // if (t.position.x <= lanes[lane])
                // {
                //     t.position = new Vector2(t.position.x + step, t.position.y);
                // }else if(t.position.x >= lanes[lane]){
                //     t.position = new Vector2(t.position.x - step, t.position.y);
                // }
            // }
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
        // }
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
