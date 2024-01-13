using UnityEngine;

public class CustomRotation : MonoBehaviour
{
    [Tooltip("The speed of the rotation")]
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up, speed * Time.deltaTime);
    }
}

