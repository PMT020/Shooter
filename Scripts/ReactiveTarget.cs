using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{

    [SerializeField]
    private int enemyHealth;

   void Start()
    {
       if(SceneController.getWave() == 2)
                
        {
            enemyHealth = 1;
        }

        if (SceneController.getWave() == 3)
        {
            enemyHealth = 2;
        }

        if(SceneController.getWave() == 4)
        {
            enemyHealth = 3;
        }
    }



    public void ReactToHit()
    {
        WonderingAI behavior = GetComponent<WonderingAI>();
        if (SceneController.getWave() == 2)
        {
            Debug.Log("Enemy Hit: Health " + (enemyHealth - 1));
            enemyHealth--;

            if (enemyHealth < 1)
            {
                if (behavior != null)
                {
                    behavior.setAlive(false);
                }

                StartCoroutine(Die());
            }


        }

        
            if (SceneController.getWave() == 3)
            {
           
                Debug.Log("Enemy Hit: Health " + (enemyHealth - 1));
                enemyHealth--;

                if (enemyHealth < 1)
                {
                    if (behavior != null)
                    {
                        behavior.setAlive(false);
                    }

                    StartCoroutine(Die());
                }

            }

        if (SceneController.getWave() == 4)
        {

            Debug.Log("Enemy Hit: Health " + (enemyHealth - 1));
            enemyHealth--;

            if (enemyHealth < 1)
            {
                if (behavior != null)
                {
                    behavior.setAlive(false);
                }

                StartCoroutine(Die());
            }

        }




    }






    public IEnumerator Die()
    {
       
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(0.1f);

        

        Destroy(this.gameObject);

        

        
    }
}
