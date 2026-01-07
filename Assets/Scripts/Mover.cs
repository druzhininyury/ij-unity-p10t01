using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;
    
    private Vector3 _startPosition;
    private float _currentDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
        _currentDistance = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _currentDistance = (_currentDistance + _speed * Time.deltaTime) % (2 * _distance);
        float shift = _currentDistance <= _distance ? _currentDistance : 2 * _distance - _currentDistance;
        
        Vector3 nextPosition = _startPosition;
        nextPosition.x += shift;
        
        transform.position = nextPosition;
    }
}
