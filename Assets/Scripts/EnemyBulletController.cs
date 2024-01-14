using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.magnitude > 1000.0f)
		{
			Destroy(gameObject);
		}
    }
	
   // Destroy the projectile on collision
   void OnCollisionEnter2D(Collision2D other)
   {
		MainCharacterController e = other.collider.GetComponent<MainCharacterController>();
		if (e != null)
		{
			e.TakeDamage();
			Destroy(gameObject);
		}
   }
}
