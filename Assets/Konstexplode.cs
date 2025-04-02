using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float radius = 20f;
    public float force = 500f;

    private void Start()
    {
        Explode();
    }

    void Explode()
    {
        Collider[] overlappedColliders = Physics.OverlapSphere(transform.position, radius);

        for (int j = 0; j < overlappedColliders.Length; j++)
        {
            Rigidbody rigidbody = overlappedColliders[j].attachedRigidbody;
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(force, transform.position, radius);
            }
        }
        Destroy(gameObject);
    }
}
