using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float timeLeft;
    int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            Move();
        }
        if (timeLeft <= 0)
            Destroy(gameObject);

        if (Input.GetKeyDown(KeyCode.Space))
            DoubleMySize();
    }

    void LateUpdate() 
    {
            
    }

    void Move()
    {
        transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime; 
    }

    void DoubleMySize()
    {
        transform.localScale = new Vector3 (transform.localScale.x * 2, transform.localScale.y * 2, transform.localScale.z * 2);
    }
}
