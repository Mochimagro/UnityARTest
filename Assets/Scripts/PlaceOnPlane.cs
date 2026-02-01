using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class PlaceOnPlane : MonoBehaviour
{
    [SerializeField] private GameObject _spawnObhect;
    private ARRaycastManager _raycastManager;
    private List<ARRaycastHit> _hits = new();

    // Start is called before the first frame update
    private void Awake()
    {
        _raycastManager = GetComponent<ARRaycastManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0) return;

        var touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began) return;

        if (_raycastManager.Raycast(touch.position, _hits, TrackableType.PlaneWithinPolygon))
        {
            var pose = _hits[0].pose;
            Instantiate(_spawnObhect, pose.position, pose.rotation);
        }
    }
}
