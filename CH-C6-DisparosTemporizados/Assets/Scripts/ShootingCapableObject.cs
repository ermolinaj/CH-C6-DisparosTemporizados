using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingCapableObject : MonoBehaviour
{
    [SerializeField] float shootingCooldown;
    [SerializeField] float bulletDuration;
    [SerializeField] Bullet bulletType;

    // Start is called before the first frame update
    void Start()
    {
        bulletType.timeLeft = bulletDuration;
        InvokeRepeating("SpawnBullet", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBullet()
    {
        Instantiate(bulletType, transform.position, new Quaternion());
    }
}
