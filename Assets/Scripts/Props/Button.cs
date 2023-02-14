using UnityEngine;

public class Button : MonoBehaviour
{
    private SpriteRenderer spriteR;
    public Sprite buttonUp;
    public Sprite buttonDown;

    // Start is called before the first frame update
    void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
        spriteR.sprite = buttonUp;
    }

    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        spriteR.sprite =
            spriteR.sprite == buttonDown ?
            buttonUp :
            buttonDown;
        Debug.Log("Trigger Enter");
    }
}
