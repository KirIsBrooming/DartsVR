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
        //DartRaycast();
        //DartStop();
    }
    //public void DartRaycast()
    //{
    //    if (DartHitSmth)
    //    {
    //        return;
    //    }

    //    Physics.Raycast(dartRayCastOrigin.transform.position, dartRayCastEnd.transform.position, out RaycastHit dartHit, dartLayerMask);
            
    //    if(!dartHit.collider)
    //    {
    //        return;
    //    }

    //    DartHitSmth = true;
    //    Debug.Log(dartHit.collider.gameObject.name);
    //}

    //public void DartStop()
    //{
    //    if (!DartHitSmth)
    //    {
    //        return;
    //    }

    //    dartRb.useGravity = false;
    //    dartRb.isKinematic = true;
    //    dartRb.velocity = new Vector3(0, 0, 0);
    //    tipCollider.enabled = false;
    //}
}
