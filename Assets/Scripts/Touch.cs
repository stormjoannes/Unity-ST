using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Touch : Sense
{
    void OnTriggerEnter(Collider other)
    {
        Aspect aspect = other.GetComponent<Aspect>();
        if (aspect != null)
        {
//Check the aspect
            if (aspect.aspectType != aspectName)
            {
                print(aspectName.ToString() + " touch Detected");
//Check if mine or AI
				if (aspectName.ToString() != "Mine")
				{
//Destroy player
                	Destroy(GameObject.FindGameObjectWithTag(aspectName.ToString()));
				}
				else
				{
					print("hoi");
//Destroy tank
					Destroy(GameObject.FindGameObjectWithTag("Player"));
				}
            }
        }
    }
}