using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallShoot : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;

    [SerializeField]
    private int damage = 1;
    
    
    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        //Debug.Log("Object Collided: " + other.gameObject.name);

        if (other.gameObject.name == "Floor")
        {
            return;
        }
        
       // Debug.Log("Object Collided: " + other.gameObject.name);

        if (player != null)
        {
            player.Hurt(damage);
   
        }
        Destroy(this.gameObject);

    }
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

}
