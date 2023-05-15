using System;
using UnityEngine;

public class MoveWithTouch : MonoBehaviour
{
    [SerializeField] float speed = 0.4f;
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

    private void FixedUpdate()
    {
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began)
        {
            if (touch.position.x < Screen.width / 2 && t.position.x < maxX)
            {
                if (lane != 0){
                    lane = lane-1;
                }
                
            }
            if (touch.position.x > Screen.width / 2 && t.position.x > minX)
            {
                if (lane != 2){
                    lane = lane+1;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (lane != 0){
                    lane = lane-1;
                }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (lane != 2){
                    lane = lane+1;
                }
        }


        Vector2 newposition = new Vector2(lanes[lane], t.position.y);
        t.position = Vector2.Lerp(t.position, newposition, speed);
    }
}
