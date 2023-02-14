using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject ObjectToFollow;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = ObjectToFollow.transform.position.x;
        position.y = ObjectToFollow.transform.position.y;

        transform.position = position;
    }
}
