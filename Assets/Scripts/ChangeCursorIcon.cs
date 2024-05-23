using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeCursorIcon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursorTexture; // Custom cursor texture
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode); // Set custom cursor on pointer enter
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode); // Reset cursor to default on pointer exit
    }
    public void ResetCursorToDefault()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode); // Reset cursor to default
    }
}
