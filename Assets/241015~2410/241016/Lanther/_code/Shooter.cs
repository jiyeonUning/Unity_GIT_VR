using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform muzzlePoint;

    [SerializeField] float ShotSpeed;

    public void Fire()
    {
        GameObject shot = Instantiate(bulletPrefab, muzzlePoint.transform.position, muzzlePoint.transform.rotation);
        Rigidbody rigidbody = shot.GetComponent<Rigidbody>();
        rigidbody.velocity = ShotSpeed * muzzlePoint.forward;
    }
}
