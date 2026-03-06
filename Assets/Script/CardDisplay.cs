using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public CardData data; // Tarik file CardData ke sini di Inspector

    public TextMeshProUGUI nameText;
    public Image artworkImage;
    public TextMeshProUGUI statsText;

    void Start()
    {
        if (data != null) LoadCard(data);
    }

    public void LoadCard(CardData newData)
    {
        data = newData;
        nameText.text = data.cardName;
        //artworkImage.sprite = data.cardArtwork;
        statsText.text = $"E:{data.Ekonomi} L:{data.Lingkungan} S:{data.Sosial}";
    }
}