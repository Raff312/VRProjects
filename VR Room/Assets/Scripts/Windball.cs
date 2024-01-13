using UnityEngine;

public class Windball : BaseSpell
{
    [Tooltip("The force of the push")]
    public float force = 5;

    new void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        if (!collision.gameObject.isStatic)
        {
            var rigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (!rigidbody.isKinematic)
            {
                rigidbody.AddForce(force * gameObject.transform.forward, ForceMode.Impulse);
            }
        }
    }
}
