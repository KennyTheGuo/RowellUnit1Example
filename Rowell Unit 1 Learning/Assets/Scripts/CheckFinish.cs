using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFinish : MonoBehaviour
{
    public FinishEffect finishEffect;
    public Elevate elevate;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "FinishLine")
        {
            finishEffect.ActivateEffect();
            //elevate.ActivateEffect();
        }
    }

}
