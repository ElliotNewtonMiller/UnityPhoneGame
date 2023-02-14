using UnityEngine;

public class MainChar : MonoBehaviour
{

    Collider2D col;
    Vector2 tilt;
    Rigidbody2D rB;

    private void Start()
    {
        col = GetComponent<Collider2D>();
        rB = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        // Turns this red when touched
        if (Input.touchCount == 0)
        { 
            return;
        }

        Touch touch = Input.GetTouch(0);
        Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

        if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
        {
            Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);

            GetComponent<SpriteRenderer>().color =
                (touchedCollider == col) ? Color.red : Color.white;
        }

        if (touch.phase == TouchPhase.Ended)
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
