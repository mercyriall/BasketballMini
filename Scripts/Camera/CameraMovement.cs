using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public void MoveCamera()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 3f, transform.position.z);
    }
}
