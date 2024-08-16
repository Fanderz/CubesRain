using UnityEngine;

public class Cube : MonoBehaviour
{
    private float minSeconds = 2.0f;
    private float maxSeconds = 5.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Renderer renderer = GetComponent<Renderer>();

        if (collision.collider is MeshCollider && renderer.material.color != Color.red)
        {
            renderer.material.color = Color.red;
        }

        Destroy(gameObject, UnityEngine.Random.Range(minSeconds, maxSeconds));
    }
}