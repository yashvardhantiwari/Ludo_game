using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerP : MonoBehaviour
{
        public bool moveNow;
    public int numberOfStepsToMove;

   public PathObjectsParent pathsParent;

    private void Awake()
    {
        pathsParent = FindObjectOfType<PathObjectsParent>();
    }
}
