using UnityEngine;

public class HardMovingGrid : MonoBehaviour
{
    private float _positionY;
    private bool flag = true;

    private void Start()
    {
        _positionY = transform.position.y;
    }

    void Update()
    {
        if (_positionY + 1 <= transform.position.y)
        {
            flag = false;
        }
        else if (_positionY - 1 >= transform.position.y)
        {
            flag = true;
        }

        if (flag)
        {
            transform.position = new Vector2(transform.position.x + 0.0029f, transform.position.y + 0.009f);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - 0.0029f, transform.position.y - 0.009f);
        }
    }

}
