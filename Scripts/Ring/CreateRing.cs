using UnityEngine;

public class CreateRing : MonoBehaviour
{
    [SerializeField] private GameObject[] _ringPref; 
    private float _lastRespawnPosition;

    private void Start()
    {
        _lastRespawnPosition = transform.position.y;
        Instantiate(_ringPref[Random.Range(0, _ringPref.Length)], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }

    private void Update()
    {
        if (transform.position.y != _lastRespawnPosition)
        {
            transform.position = new Vector2(transform.position.x * -1, transform.position.y);
            _lastRespawnPosition = transform.position.y;
            Instantiate(_ringPref[Random.Range(0, _ringPref.Length)], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
    }
}
