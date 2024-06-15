using UnityEngine;

public class PlayerInsideGrid : MonoBehaviour
{
    [SerializeField] private RotationRing _ring;
    [SerializeField] private bool _bonusEnabled = true;

    private GameObject _camera;
    private CameraMovement _cameraScript;

    private GameObject _player;
    private Player _playerScript;
    private Transform _playerPos;

    private GameObject _playerTrajectory;
    private TrajectoryMove _playerTrajectoryScript;

    private GameObject _cursor;
    private CursorDetected _cursorDetected;

    private void Start()
    {
        _cursor = GameObject.FindGameObjectWithTag("GameController");
        _cursorDetected = _cursor.GetComponent<CursorDetected>();

        _player = GameObject.FindGameObjectWithTag("Player");
        _playerScript = _player.GetComponent<Player>();
        _playerPos = _player.GetComponent<Transform>();

        _playerTrajectory = GameObject.FindGameObjectWithTag("Trajectory");
        _playerTrajectoryScript = _playerTrajectory.GetComponent<TrajectoryMove>();

        _camera = GameObject.FindGameObjectWithTag("MainCamera");
        _cameraScript = _camera.GetComponent<CameraMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _playerScript.enabled = true;
        _playerTrajectoryScript.enabled = true;
        _playerPos.position = transform.position;

        if (_bonusEnabled == true)
        {
            Score.instance.UpdateScore();
            _bonusEnabled = false;
            _cameraScript.MoveCamera();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_cursorDetected.isPressed == true)
        {
            _ring.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _playerTrajectoryScript.enabled = false;
        _playerScript.enabled = false;
        _ring.enabled = false;
    }
}
