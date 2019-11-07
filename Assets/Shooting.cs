using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Shooting : MonoBehaviour
{
    public Rigidbody2D projectile;
    public GameObject gun;
    public float fireRate=20;
    public double lastTime=0;
    public Transform barrel;
    public float nextFire=0;
        void Update()
            
    {

         if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                gun.transform.LookAt(touchPos);
                var bullet = Instantiate(projectile, barrel.position, barrel.rotation);
                bullet.AddForce(touchPos*0.00005f);
                lastTime = Time.time;
           

        }
              
        
        
    }
}
