using UnityEngine;

public class MovingGridTrigger : MonoBehaviour
{
    [SerializeField] private MovingGrid _movingGrid;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _movingGrid.enabled = false;
    }
}
