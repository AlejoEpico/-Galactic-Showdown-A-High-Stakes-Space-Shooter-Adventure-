using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabEnemy;
    public int max_Enemy;
    public int current_EnemyNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemy",0,3);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    void CreateEnemy(){
        if(current_EnemyNumber<max_Enemy)
        Instantiate(prefabEnemy);
        current_EnemyNumber++;
    }
}
