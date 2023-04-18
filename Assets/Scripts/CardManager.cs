using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class CardManager : MonoBehaviour {
    public int a = 0, b = 0;
    public char symbol = '+';
    public void SetNumbers(int a, char symbol, int b) {
        this.a = a;
        this.b = b;
        this.symbol = symbol;
        GetComponent<TextMeshPro>().text = a + " " + symbol + " " + b;
    }
}
