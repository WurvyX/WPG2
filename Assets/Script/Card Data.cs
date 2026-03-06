using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Cards/CardData")]
public class CardData : ScriptableObject
{
    public string cardName;
    public Sprite cardArtwork;

    [Header("Stats Impact")]
    public int Ekonomi;
    public int Lingkungan;
    public int Sosial;

    public int durationDays;
}