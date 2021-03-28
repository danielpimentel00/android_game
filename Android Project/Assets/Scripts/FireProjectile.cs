using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public Transform ProjectileSpawner;
    public bool shoot;

    private void Start()
    {
        StartCoroutine("ShootProjectile");
    }

    private void FixedUpdate()
    {
        
    }

    IEnumerator ShootProjectile()
    {
        while (true)
        {
            Rigidbody2D ProjectileInstance;
            ProjectileInstance = Instantiate(projectile, ProjectileSpawner.position, ProjectileSpawner.rotation) as Rigidbody2D;
            ProjectileInstance.AddForce(-ProjectileSpawner.right * 750f);

            yield return new WaitForSeconds(0.3f);
        }
        
    }

    public void CanShoot()
    {
        shoot = true;
    }

    public void CantShoot()
    {
        shoot = false;
    }
}
