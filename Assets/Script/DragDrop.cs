using UnityEngine;
using UnityEngine.EventSystems; // WAJIB ADA untuk deteksi Mouse

public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 startPosition;
    private Transform startParent;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        // Tambahkan komponen Canvas Group secara otomatis jika belum ada
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null) canvasGroup = gameObject.AddComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Simpan posisi awal buat jaga-jaga kalau batal dilepas di slot
        startPosition = transform.position;
        startParent = transform.parent;

        canvasGroup.alpha = 0.6f; // Bikin kartu agak transparan saat ditarik
        canvasGroup.blocksRaycasts = false; // Supaya mouse bisa "tembus" ke slot di bawahnya
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Membuat posisi kartu mengikuti posisi mouse
        rectTransform.anchoredPosition += eventData.delta / GetComponentInParent<Canvas>().scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        // Jika kartu tidak jatuh ke slot yang benar, balikkan ke posisi awal
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
    }
}