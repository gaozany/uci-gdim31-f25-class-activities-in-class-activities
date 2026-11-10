using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _speed = 2.0f;

    private bool _isChasing;


    private void Update()
    {
        if (_isChasing)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                _playerTransform.position,
                _speed * Time.deltaTime
           );
        }
    }

    public void StartChasing()
    {
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }
}    