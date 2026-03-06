using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Cards/CardData")]
public class CardData : ScriptableObject
{
    public string cardName;
    public Sprite cardArtwork;

    [Header("Stats Impact")]
    public int ekonomi;
    public int lingkungan;
    public int sosial;

    public int durationDays;
}