using UnityEngine;
using Random = UnityEngine.Random;

public class AmazingInteraction : MonoBehaviour
{
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    [ContextMenu("Change Cube Color")]
    public void ChangeCubeColor()
    {
        _meshRenderer.material.color = Random.ColorHSV();
    }
    
}
