using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonderingAI : MonoBehaviour
{
    [SerializeField]
    private float speed = 3.0f;

    [SerializeField]
    private float obstacleRange = 10.0f;

    [SerializeField]
    private GameObject fireballPrefab;

    [SerializeField]
    private GameObject OrbPrefab;

    private GameObject Orb;

    private GameObject fireball;

    private bool isAlive;

    private int OrbCount = 0;

    private void Start()
    {
        isAlive = true;

        
    }

    public void setAlive(bool isAlive)
    {
        this.isAlive = isAlive;
    }


    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

        }
 
            

        
    
        

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.SphereCast(ray, 0.75f, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;

            if (hitObject.GetComponent<PlayerCharacter>())
            {

                if(fireball == null)
                {
                    fireball = Instantiate(fireballPrefab) as GameObject;

                    fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                    fireball.transform.rotation = transform.rotation;
                    //transform.Rotate(0, 90, 0);
                }

            }
            else if(hit.distance < obstacleRange)
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }

        if (!isAlive)
        {
            
            
                Orb = Instantiate(OrbPrefab) as GameObject;

                Orb.transform.position = transform.TransformPoint(Vector3.forward * 1f);
                Orb.transform.rotation = transform.rotation;
                OrbCount++;
            if(OrbCount > 1)
            {
                Destroy(Orb);
            }


            

            

            
          
        }


    }
}
