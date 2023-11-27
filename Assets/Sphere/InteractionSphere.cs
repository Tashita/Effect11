using UnityEngine;

public class InteractionSphere : MonoBehaviour
{
    private Material material;

    private string positionProperty = "_Center_Sphere";
    private string radiusProperty = "_Sphere_Radius";
    // could add [SerializeField] attribute or make public to set from inspector

    void Start()
    {
        material = transform.parent.GetComponent<Renderer>().material;
        /*
        If the script object is a child of the FracturedCube can use this.
        Otherwise could add [SerializeField] to expose the material field,
        or provide a serialized field for the Transform/MeshRenderer of cube
        */
        /*
        Use `.material` instead to support multiple of these.
        Would then also need to Destroy(material) in OnDestroy,
        and might need to remove [ExecuteInEditMode] as creating 
        materials while not in play mode might leak them :(
        */
    }

    void Update()
    {
        material.SetVector(positionProperty, transform.position);
        material.SetFloat(radiusProperty, transform.localScale.x/2);
        /*
        Could also combine these into a single Vector4 property, e.g.
        Vector4 vector = transform.position;
        vector.w = transform.localScale.x;
        material.SetVector(combinedProperty, vector);
        */
    }
}