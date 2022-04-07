using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldClickManager : MonoBehaviour
{
    void Update()
    {
        WorldClick();
    }

    [SerializeField] Vector3 clickPosition;
    [SerializeField] RaycastHit hit;
    [SerializeField] Ray worldRay;

    public void WorldClick()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        worldRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (!Physics.Raycast(worldRay.origin, hit.point))
        {
            return;
        }

        clickPosition = hit.point;

        Debug.Log(clickPosition);
    }
}

