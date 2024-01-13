using UnityEngine;

public abstract class BaseSpell : MonoBehaviour
{
    protected void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}