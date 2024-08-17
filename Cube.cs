using UnityEngine;

public class Cube : MonoBehaviour
{
    private float _minSeconds = 2.0f;
    private float _maxSeconds = 5.0f;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider is MeshCollider && _renderer.material.color != Color.red)
        {
            _renderer.material.color = Color.red;
        }

        Destroy(gameObject, UnityEngine.Random.Range(_minSeconds, _maxSeconds));
    }
}