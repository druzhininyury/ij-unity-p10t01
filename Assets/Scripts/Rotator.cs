using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _angleSpeed;

    void Update()
    {
        transform.Rotate(Vector3.up, _angleSpeed * Time.deltaTime);
    }
}
