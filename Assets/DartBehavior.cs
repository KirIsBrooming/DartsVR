using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartBehavior : MonoBehaviour
{
    [Header("References")]
    public Transform dartOrigin;
    public Rigidbody dartRb;
    public GameObject dartRayCastOrigin;
    public GameObject dartRayCastEnd;
    public LayerMask dartLayerMask;
    public bool DartHitSmth = false;
    public Collider tipCollider;
    void Update()
    {
        DartRaycast();
    }
    public void DartRaycast()
    {
        Physics.Raycast(dartRayCastOrigin.transform.position, dartRayCastEnd.transform.position, out RaycastHit dartHit, dartLayerMask);
        if(!dartHit.collider)
        {
            DartHitSmth = false;
            DartMove();
            return;
        }

        else if (dartHit.collider)
        {
            DartHitSmth = true;
            DartStop();
        }
        Debug.Log(dartHit.collider.gameObject.name);
   }

    public void DartStop()
    {
        dartRb.useGravity = false;
        dartRb.isKinematic = true;
        dartRb.velocity = new Vector3(0, 0, 0);
        tipCollider.enabled = false;
    }
    public void DartMove()
    {
        dartRb.useGravity = true;
        dartRb.isKinematic = false;
        tipCollider.enabled = true;
    }
}
