using UnityEngine;

public class bomb_behavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground")) 
        {
            Destroy(gameObject);
        }
    }
    /*// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {}*/

    /*// Update is called once per frame
    void Update()
    {}*/
}
