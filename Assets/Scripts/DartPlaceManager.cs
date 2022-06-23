using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartPlaceManager : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] public GameObject dartPrefab;
    [SerializeField] public GameObject dartPosition;
    [SerializeField] public LayerMask planeLayer;

    private void Update()
    {
        Placement();
    }

    public void Placement()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        Ray cameraToMouseRay = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (!Physics.Raycast(cameraToMouseRay, out RaycastHit c2mrHit, planeLayer))
        {
            return;
        }

        Debug.Log("Plane Click Registered");
        dartPosition.transform.position = c2mrHit.point;
        Instantiate(dartPrefab, dartPosition.transform.position, transform.rotation * Quaternion.Euler(90f, 0f, 0f));
    }
}

