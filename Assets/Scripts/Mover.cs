using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    void Update()
    {
        transform.position += transform.forward * (_speed * Time.deltaTime);
    }
}
