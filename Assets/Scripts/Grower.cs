using System;
using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _boundSize;

    private float _currentExtendSize;
    
    // Start is called before the first frame update
    void Start()
    {
        _currentExtendSize = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float boundExtendSize = _boundSize - 1f;
        _currentExtendSize = (_currentExtendSize + _speed * Time.deltaTime) % (2f * boundExtendSize);
        float extension = _currentExtendSize <= boundExtendSize ? _currentExtendSize : (2f * boundExtendSize - _currentExtendSize);

        Vector3 nextScale = new Vector3(1f, 1f, 1f) * (extension + 1f);
        transform.localScale = nextScale;
    }

    private void OnValidate()
    {
        if (_boundSize < 1f)
        {
            _boundSize = 1f;
        } 
    }
}
