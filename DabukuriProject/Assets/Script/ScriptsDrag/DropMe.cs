using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropMe : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public string estadoCerto;
	public AudioClip nomeTocar;
	public AudioSource tocador;
	public Image containerImage;
	public Image receivingImage;
	private Color normalColor;
	public GameObject nommeObjeto;
	public Color highlightColor = Color.yellow;
    bool acertou = false;
	public static int passoscertos, podepassar;
	public void OnEnable ()
	{
		if (containerImage != null)
			normalColor = containerImage.color;
	}
	
	public void OnDrop(PointerEventData data)
	{
		containerImage.color = normalColor;
		
		if (receivingImage == null)
			return;
		
		Sprite dropSprite = GetDropSprite (data);
		if (dropSprite != null)
        {
            if (acertou)
            {
				Debug.Log("Acertou");
                receivingImage.overrideSprite = dropSprite;
				passoscertos = passoscertos+1;
				nommeObjeto.SetActive (true);
				tocador.PlayOneShot (nomeTocar);
				podepassar = 1;


            }
            else
            {
                Debug.Log("Errou");
            }
        }
	}

	public void OnPointerEnter(PointerEventData data)
	{
		if (containerImage == null)
			return;
		
		Sprite dropSprite = GetDropSprite (data);
		if (dropSprite != null)
			containerImage.color = highlightColor;
	}

	public void OnPointerExit(PointerEventData data)
	{
		if (containerImage == null)
			return;
		
		containerImage.color = normalColor;
	}
	
	private Sprite GetDropSprite(PointerEventData data)
	{
		var originalObj = data.pointerDrag;
        string estadoArrastado = originalObj.gameObject.GetComponent<DragMe>().GetEstado();
        if (estadoArrastado.Equals(this.estadoCerto))
        {
            this.acertou = true;
        }
        else
        {
            this. acertou = false;

        }
        Debug.Log(originalObj.gameObject);
			
		if (originalObj == null)
			return null;
		
		var dragMe = originalObj.GetComponent<DragMe>();
		if (dragMe == null)
			return null;
		
		var srcImage = originalObj.GetComponent<Image>();
		if (srcImage == null)
			return null;
		
		return srcImage.sprite;
	}
}
