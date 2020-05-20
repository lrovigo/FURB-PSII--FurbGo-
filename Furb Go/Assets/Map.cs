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
        bloco = bloco.Remove(0,6);
        var find = new Caminhos();
        LabelBlocoSelecionado = GameObject.Find("LabelBlocoSelecionado").GetComponent<Text>();
        //LabelBlocoSelecionado.text = $"Você selecionou: {bloco}";
        LabelBlocoSelecionado.text = find.FindPath(bloco);
    }
}
