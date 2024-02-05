using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField]
    private int Hdamage = 2;

    [SerializeField]
    private float HTime;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HTime += Time.deltaTime;

        if(HTime > 4)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player2 = other.GetComponent<PlayerCharacter>();



        if(player2 != null)
        {
            player2.Heal(Hdamage);

        }
           

        



        Destroy(this.gameObject);
    }
}
