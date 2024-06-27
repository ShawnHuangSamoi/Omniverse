using UnityEngine;

public class GrassInteractor : MonoBehaviour
{
    [SerializeField]
    private string playerProperty;
    [SerializeField]
    private Material grassMaterial;
    
    void Update()
    {
        grassMaterial.SetVector(playerProperty, transform.position);
    }
}
