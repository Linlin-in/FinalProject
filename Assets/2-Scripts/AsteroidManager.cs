using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [SerializeField] GameObject asteroid1;
    [SerializeField] GameObject asteroid2;
    [SerializeField] int num_ast=10;
    [SerializeField] int gridSpace=100;

    void Start(){
        PlaceAsteroids();
    }

    void PlaceAsteroids(){
        for(int x=0; x < num_ast; x++){
            for(int y=0; y < num_ast; y++){
                for(int z=0; z < num_ast; z++){
                                    InstantiateAsteroid(x, y, z);
                }
            } 
        }
    }

    void InstantiateAsteroid(int x, int y, int z)
    {

        var asteroid = Random.Range(0, 1f) < .5f ? asteroid1 : asteroid2;
        
        Instantiate(asteroid, new Vector3(transform.position.x+(x*gridSpace)+ AsteroidOffset(),
                                transform.position.y+(y*gridSpace)+ AsteroidOffset(),
                                transform.position.z+(z*gridSpace)+ AsteroidOffset())  , 
            
        Quaternion.identity, transform);
    }

    float AsteroidOffset(){
        return Random.Range(-gridSpace/2f,gridSpace/2f);
    }

}
