 using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody.velocity = new Vector2 (Random.Range(2f,8f),Random.Range(2f,8f));
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Block"))
        {
            Destroy(col.gameObject);
        }
        
    
    }

}
