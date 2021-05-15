using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerP : PlayerP
{
    private void Start()
    {
        // MoveSteps();
        StartCoroutine("MoveStepsEnum");
    }

    public void MoveSteps()
    {
        for (int i = 0; i < 5; i++)
        {
            transform.position = pathsParent.CommonPath[1].transform.position;
        }
    }
    IEnumerator MoveStepsEnum()
    {
        for (int i = 0; i < 5; i++)
        {
            transform.position = pathsParent.CommonPath[i].transform.position;
            yield return new WaitForSeconds(1f);
        }
    }
}