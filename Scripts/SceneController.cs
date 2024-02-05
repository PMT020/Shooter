using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    private GameObject enemy;


    [SerializeField]
    private static int wave = 0;

    
    private float time = 0.00f;

    private static int EnemyCount;



    public static int getWave()
    {
        return wave;
    }


    public static int getECount()
    {
        EnemyCount--;
        return EnemyCount;
    }



    private void Start()
    {

       


    }

    void Update()
    {
      if(enemy == null)
        {
            if (wave == 0)
            {
                wave += 1;
            }
            else if(wave == 1)
            {
                enemy = Instantiate(enemyPrefab) as GameObject;
                enemy.transform.position = new Vector3(0, 1, 0);
                float angle = Random.Range(0, 360);
                enemy.transform.Rotate(0, angle, 0);
                EnemyCount++;
                wave += 1;
                    

                
                


            }
            else if (wave == 2)
            {
                time += Time.deltaTime;
                if(time >= 3.0f)
                {
                    for(int i = 0; i < 2; i++)
                    {

                        enemy = Instantiate(enemyPrefab) as GameObject;
                        enemy.transform.position = new Vector3(0, 1, 0);
                        float angle = Random.Range(0, 360);
                        enemy.transform.Rotate(0, angle, 0);
                        EnemyCount++;
                        
                    }
                    
                    
                        wave += 1;
                        time = 0.0f;

                    
           

                }
                
            
            }

            

            if (wave == 3)
            {
                time += Time.deltaTime;

                if (time >= 3.0f)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        enemy = Instantiate(enemyPrefab) as GameObject;
                        enemy.transform.position = new Vector3(0, 1, 0);
                        float angle = Random.Range(0, 360);
                        enemy.transform.Rotate(0, angle, 0);
                    }
                    
                        wave += 1;

                    
                    

                }

                
                
               
            }

            

           
        }
    }


}


