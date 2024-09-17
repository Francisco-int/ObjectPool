using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
   [SerializeField] float speedObstacule;
   [SerializeField] float timeDisable;
    float time;
    private void Update()
    {
        transform.Translate(transform.right * -speedObstacule * Time.deltaTime); 
        time += Time.deltaTime;
        if(time > timeDisable)
        {
            gameObject.SetActive(false);
            time = 0;
        }
    }
}

