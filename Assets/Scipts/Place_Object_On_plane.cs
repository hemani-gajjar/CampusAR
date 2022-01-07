using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Place_Object_On_plane : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private Pose placementPose;
    private bool placementPoseIsValid;
    private bool isObjectPlaced;

    
    public GameObject positionIndicator;
    public GameObject prefabToPlace;
    public Camera aRCamera;
    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();

    }
    void Update()
    {
        
        if (!isObjectPlaced)
        {
            UpdatePlacementPose();
            if(placementPoseIsValid && Input.touchCount> 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                placeObject();
            }
        }
        
    }
    private void UpdatePlacementPose()
    {
        var screenCenter = aRCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();

        raycastManager.Raycast(screenCenter, hits, TrackableType.AllTypes);
        
        placementPoseIsValid = hits.Count > 0;

        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose;
            var cameraforward = aRCamera.transform.forward;
            var cameraBearing = new Vector3(cameraforward.x, 0, cameraforward.z).normalized;

            placementPose.rotation = Quaternion.LookRotation(cameraBearing);
            positionIndicator.SetActive(true);
            positionIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);

        }
        else
        {
            positionIndicator.SetActive(false);
        }
    }

    private void placeObject()
    {
        Instantiate(prefabToPlace, placementPose.position, placementPose.rotation);
        isObjectPlaced = true;
        positionIndicator.SetActive(false);

    }



}
