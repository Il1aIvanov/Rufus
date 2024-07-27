using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Form3 : MonoBehaviour
{
    [SerializeField]
    Transform formPlace3;

    private Vector2 initPosition;
    private float startPosX, startPosY;
    public static bool locked;

    void Start()
    {
        initPosition = transform.position;
    }

    private void Update()
    {
        if (Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        startPosX = touchPos.x - transform.position.x;
                        startPosY = touchPos.y - transform.position.y;
                    }
                    break;

                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        transform.position = new Vector2(touchPos.x - startPosX, touchPos.y - startPosY);
                    }
                    break;
                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - formPlace3.position.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - formPlace3.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(formPlace3.position.x, formPlace3.position.y);
                        locked = true;
                    }
                    else
                    {
                        transform.position = new Vector2(initPosition.x, initPosition.y);
                    }
                    break;


            }
        }
    }
}
