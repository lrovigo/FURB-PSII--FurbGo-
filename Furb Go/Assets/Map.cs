using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    public Text LabelBlocoSelecionado;
    public string BlocoSelecionado = string.Empty;
    public void SetSelected(string bloco)
    {
        BlocoSelecionado = bloco;
        LabelBlocoSelecionado = GameObject.Find("LabelBlocoSelecionado").GetComponent<Text>();
        LabelBlocoSelecionado.text = $"Você selecionou: {bloco}";
    }
}
