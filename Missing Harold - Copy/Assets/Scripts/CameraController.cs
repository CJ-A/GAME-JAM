using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(target.transform.position.x, target.transform.position.y);

    }
}

