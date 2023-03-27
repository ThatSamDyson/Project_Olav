using UnityEngine;

public class SetTexture : MonoBehaviour
{
    public Material PenguinMat;
    public Renderer renderer;

    private void Start()
    {
        //PenguinMat = Resources.Load<Material>("PenguinMat");
        renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", Random.ColorHSV());// = PenguinMat;
        //Material oldMaterial = meshRenderer.material;
        //Debug.Log("Applied Material: " + oldMaterial.name);

        renderer.material = PenguinMat;
    }
}
