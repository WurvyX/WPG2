using UnityEngine;
using TMPro; // Pastikan pakai TextMeshPro

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Resources")]
    public int statEkonomi = 50;
    public int statLingkungan = 50;
    public int statSosial = 50;

    [Header("UI Reference")]
    public TextMeshProUGUI textEkonomi;
    public TextMeshProUGUI textLingkungan;
    public TextMeshProUGUI textSosial;

    void Awake() { Instance = this; }

    void Start() { UpdateUI(); }

    public void UpdateResources(int e, int l, int s)
    {
        statEkonomi += e;
        statLingkungan += l;
        statSosial += s;
        UpdateUI();
    }

    void UpdateUI()
    {
        textEkonomi.text = "Ekon: " + statEkonomi;
        textLingkungan.text = "Lingk: " + statLingkungan;
        textSosial.text = "Sos: " + statSosial;
    }
}