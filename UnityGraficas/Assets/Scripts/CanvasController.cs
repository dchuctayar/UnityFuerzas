using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasController : MonoBehaviour
{
    public Image imgSelector;
 
    // Start is called before the first frame update
    public void ChangePickableBallColor(bool isSelect)
    {
        if (isSelect)
        {
            imgSelector.color = Color.green;
        }
        else
        {
            imgSelector.color = Color.white;
        }
    }

    public void OcultarCursor(bool ocultar)
    {
        imgSelector.enabled = !ocultar;
    }
}
