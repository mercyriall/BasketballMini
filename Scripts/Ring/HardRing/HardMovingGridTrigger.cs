using UnityEngine;

public class HardMovingGridTrigger : MonoBehaviour
{
    [SerializeField] private HardMovingGrid _hardMovingGrid;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _hardMovingGrid.enabled = false;
    }
}
