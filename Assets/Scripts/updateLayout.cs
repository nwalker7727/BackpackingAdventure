using UnityEngine;
using UnityEngine.UI;

public class CanvasPositionUpdater : MonoBehaviour
{
    public Canvas canvas;

    void UpdateCanvasLayout()
    {
        LayoutRebuilder.ForceRebuildLayoutImmediate(canvas.GetComponent<RectTransform>());
    }
}
