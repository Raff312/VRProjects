using UnityEngine;

public class MoveSpell : MonoBehaviour
{
    [Tooltip("Speed of the spell")]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed < float.Epsilon)
        {
            Debug.Log("There is no speed");
            return;
        }

        transform.position += transform.forward * (speed * Time.deltaTime);
    }
}
