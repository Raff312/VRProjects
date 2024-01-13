using UnityEngine;

public class Fireball : BaseSpell
{
    [Tooltip("Time before destroying in seconds")]
    public float lifeTime = 0.0f;

    new void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        if (!collision.gameObject.isStatic)
        {
            if (collision.gameObject.GetComponent<Rigidbody>().isKinematic)
            {
                collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                collision.gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
            } 
            else
            {
                collision.gameObject.GetComponent<Renderer>().material.color = Color.black;
                Destroy(collision.gameObject, lifeTime);
            }
        }
    }
}
