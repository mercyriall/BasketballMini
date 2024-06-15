using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private CursorDetected _cursor;

    private Rigidbody2D _rb;

    private float _shootPower = 0f;
    private float _maxShootPower = 3f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    public void Dead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ShootBall()
    {
        _shootPower = _cursor.distance;

        if (_shootPower >= 3f)
        {
            //_rb.AddForce(new Vector2(_cursor.distaceVector.x * _maxShootPower,
                //_cursor.distaceVector.y * _maxShootPower));
            _rb.velocity = new Vector2(_cursor.distaceVector.x * _maxShootPower,
                _cursor.distaceVector.y * _maxShootPower);
        }
        else
        {
            //_rb.AddForce(new Vector2(_cursor.distaceVector.x * _shootPower,
                //_cursor.distaceVector.y * _shootPower));
            _rb.velocity = new Vector2(_cursor.distaceVector.x * _shootPower,
                _cursor.distaceVector.y * _shootPower);
        }
    }
}