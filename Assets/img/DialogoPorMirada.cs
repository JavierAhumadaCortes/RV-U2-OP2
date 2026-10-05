using TMPro;
using UnityEngine;

public class DialogoPorMirada : MonoBehaviour
{
    [SerializeField] private GameObject burbuja;
    [SerializeField] private TextMeshProUGUI texto;
    [SerializeField, TextArea(2, 4)] private string mensaje =
        "Aquí llegan los pedidos de la granja";

    private void Awake()
    {
        if (burbuja == null || texto == null)
        {
            Debug.LogError("Asigna Burbuja y Texto en el Inspector.", this);
            enabled = false;
            return;
        }

        texto.text = mensaje;
        burbuja.SetActive(false);
    }

    public void OnPointerEnter()
    {
        burbuja.SetActive(true);
    }

    public void OnPointerExit()
    {
        burbuja.SetActive(false);
    }

    // Cardboard puede enviar clic al mismo objeto interactivo.
    public void OnPointerClick() { }
}
