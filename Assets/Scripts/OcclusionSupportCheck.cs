using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class OcclusionSupportCheck : MonoBehaviour
{
    [SerializeField] private AROcclusionManager _occlusion;

    void Start()
    {
        if (_occlusion == null)
        {
            Debug.LogError("AROcclusionManager is not assigned.");
            return;
        }

        var desc = _occlusion.subsystem?.subsystemDescriptor;
        if (desc == null)
        {
            Debug.LogError("Occlusion subsystem descriptor is null (AR not initialized yet?).");
            return;
        }

        Debug.Log($"supportsHumanSegmentationDepthImage: {desc.supportsHumanSegmentationDepthImage}");
        Debug.Log($"supportsHumanSegmentationStencilImage: {desc.supportsHumanSegmentationStencilImage}");
        Debug.Log($"supportsEnvironmentDepthImage: {desc.supportsEnvironmentDepthImage}");
    }
}
