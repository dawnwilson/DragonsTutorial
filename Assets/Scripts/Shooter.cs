using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    private Vector3 offsetProjectile = new Vector3(1.5f, 0, 0);

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var projectile = Instantiate(projectilePrefab, transform.position + offsetProjectile, projectilePrefab.transform.rotation);
        }
    }
}
