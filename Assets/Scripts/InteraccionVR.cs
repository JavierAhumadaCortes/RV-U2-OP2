using UnityEngine;

public class InteraccionVR : MonoBehaviour
{
    private Renderer rend;
    private Color colorOriginal;

    void Start()
    {
        rend = GetComponent<Renderer>();

        if (rend != null)
        {
            colorOriginal = rend.material.color;
        }
    }

    public void OnPointerEnter()
    {
        Debug.Log("Reticula sobre: " + gameObject.name);

        if (rend != null)
        {
            rend.material.color = Color.green;
        }
    }

    public void OnPointerExit()
    {
        Debug.Log("Reticula salio de: " + gameObject.name);

        if (rend != null)
        {
            rend.material.color = colorOriginal;
        }
    }

    public void OnPointerClick()
    {
        Debug.Log("Click sobre: " + gameObject.name);
    }
}