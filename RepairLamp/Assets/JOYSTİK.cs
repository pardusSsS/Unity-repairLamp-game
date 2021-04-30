using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JOYSTİK : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public Image arkaplan;
    public Image joystikn;
    public Vector2 koordinat2;
    public Vector3 koordinat3;
   public  void OnDrag(PointerEventData joystik)
    {
        koordinat2 = Vector2.zero;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(arkaplan.rectTransform, joystik.position,joystik.pressEventCamera,out koordinat2))
        {
            koordinat2.x = (koordinat2.x / arkaplan.rectTransform.sizeDelta.x);
            koordinat2.y = (koordinat2.y / arkaplan.rectTransform.sizeDelta.y);

            float x = (arkaplan.rectTransform.pivot.x == 1) ? koordinat2.x * 2 + 1 : koordinat2.x * 2 - 1;
            float y = (arkaplan.rectTransform.pivot.y == 1) ? koordinat2.y * 2 + 1 : koordinat2.y * 2 - 1;

            koordinat3 =new Vector3 (x, 0, y);
            koordinat3 = (koordinat3.magnitude > 1.0f) ? koordinat3.normalized : koordinat3;
            joystikn.rectTransform.anchoredPosition = new Vector3(koordinat3.x * (arkaplan.rectTransform.sizeDelta.x / 2.5f),
                                                                  koordinat3.z * (arkaplan.rectTransform.sizeDelta.y / 2.5f));

        }
    } 
    public void OnPointerDown(PointerEventData joystik) 
    {
       OnDrag(joystik);
    }
    public void OnPointerUp(PointerEventData joystik) 
    {
        koordinat3 = Vector3.zero;
        joystikn.rectTransform.anchoredPosition = Vector3.zero;
    }

    public float yatay()
    {
        return koordinat3.x;
    }

    public float dikey()
    {
        return koordinat3.z;
    }
}
