using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public GameObject characterSelectUi;
    public Player[] players;

   public void SelectCharacter(int index)
    {
        Instantiate(players[index], Vector2.zero, Quaternion.identity);
        characterSelectUi.SetActive(false);
    }
}
