using UnityEngine;

public class SetTexture : MonoBehaviour
{
    public Material PenguinMat;
    public Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_Color", Random.ColorHSV());
      

        renderer.material = PenguinMat;
    }


    public void ChangeColour(Color ColourOfPaintCan)
    {
        renderer.material.SetColor("_Colour", ColourOfPaintCan);

    }
}
