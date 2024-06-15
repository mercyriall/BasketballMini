using UnityEngine;

public class DeleteRing : MonoBehaviour
{
    private GameObject _deadPoint;

    private void Start()
    {
        _deadPoint = GameObject.FindGameObjectWithTag("Finish");
    }

    void Update()
    {
        if (transform.position.y < _deadPoint.transform.position.y)
        {
            Destroy(this.gameObject);
        }
    }
}
