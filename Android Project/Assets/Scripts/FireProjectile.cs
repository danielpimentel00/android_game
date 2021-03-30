using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public Transform ProjectileSpawner;

    private void Start()
    {
        StartCoroutine("ShootProjectile");
    }

    IEnumerator ShootProjectile()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);

            Rigidbody2D ProjectileInstance;
            ProjectileInstance = Instantiate(projectile, ProjectileSpawner.position, ProjectileSpawner.rotation) as Rigidbody2D;
            ProjectileInstance.AddForce(-ProjectileSpawner.right * 750f);

            SoundManager.PlaySound("laser_29");
        }
        
    }
}
