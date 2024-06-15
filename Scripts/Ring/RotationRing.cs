using UnityEngine;

public class RotationRing : MonoBehaviour
{
    [SerializeField] private float offset = -90;

    void Update()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

        if (rotateZ + offset > 30.0f)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 30.0f);
        }
        else if (rotateZ + offset < -30.0f)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, -30.0f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
        }
    }
}
