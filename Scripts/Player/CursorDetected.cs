using UnityEngine;

public class CursorDetected : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TrajectoryMove _trajectory;

    private float _distance = 0f;
    public float distance { get { return _distance; } }

    private Vector2 _startPosition;

    private Vector2 _lastPosition;
    public Vector2 lastPosition { get { return _lastPosition; } }

    private Vector2 _distaceVector;
    public Vector2 distaceVector {  get { return _distaceVector; } }

    private bool _isPressed = false;
    public bool isPressed { get { return _isPressed; } }

    private void OnMouseDown()
    {
        _startPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    Vector2 pos;
    private void OnMouseDrag()
    {
        _isPressed = true;
        _lastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        CalculateDistance();
        if (distance >= 3f && _player.enabled)
        {
            _trajectory.ShowTrajectory(_player.transform.position, _distaceVector * 3f);
        }
        else if (distance < 3f && _player.enabled)
        {
            _trajectory.ShowTrajectory(_player.transform.position, _distaceVector * distance);
        }
    }

    private void OnMouseUp()
    {
        _trajectory.HideTrajectory();

        _isPressed = false;
        _lastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        CalculateDistance();

        if (_player.enabled == true)
        {
            _player.ShootBall();
        }
    }

    private void CalculateDistance()
    {
        _distaceVector = new Vector2(_lastPosition.x - _startPosition.x, _lastPosition.y - _startPosition.y);

        _distance = Mathf.Sqrt(Mathf.Pow(distaceVector.x, 2) + Mathf.Pow(distaceVector.y, 2));
    }
}
