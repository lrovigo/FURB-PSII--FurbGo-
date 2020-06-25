using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
   
    public class ResultadoDescricao : MonoBehaviour
    {
        public static KeyValuePair<Bloco, string> keyPair;
        private bool Posicionando = false;
        public Text LabelDescription;
        void Update()
        {
            if (!Posicionando)
            {
                Posicionando = true;
                LabelDescription.text = keyPair.Value;
            }
        }
    }
}
