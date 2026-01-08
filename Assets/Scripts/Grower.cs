using System;
using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private void Update()
    {
        float currentScaleValue = transform.localScale.x;
        float nextScaleValue = currentScaleValue + _speed * Time.deltaTime;
        Vector3 nextScale = new Vector3(1f, 1f, 1f) * nextScaleValue;
        transform.localScale = nextScale;
    }
}
