using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Aspect : MonoBehaviour {
	//alle verschillende characters aanmaken
    public enum AspectTypes {
        PLAYER,
        Enemy,
        Enemy1,
        Enemy2,
        Enemy3,
        Enemy4,
        Mine,
    }
    public AspectTypes aspectType;
}