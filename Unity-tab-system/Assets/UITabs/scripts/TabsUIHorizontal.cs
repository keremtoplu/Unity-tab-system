using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TabsUIHorizontal : MonoBehaviour
{
    [SerializeField]
    private List<Button> tabBtns;

    [SerializeField]
    private List<GameObject> tabContent;

#if UNITY_EDITOR

    private void Start()
    {
        for (int i = 0; i < tabBtns.Count; i++)
        {
            var index = i;
            tabBtns[i].onClick.AddListener(() => OnBtnClicked(index));
        }
    }
    public void OnBtnClicked(int itemIndex)
    {
        CloseAllContent();
        tabContent[itemIndex].SetActive(true);

    }


    private void CloseAllContent()
    {
        for (int i = 0; i < tabContent.Count; i++)
        {
            tabContent[i].SetActive(false);
        }
    }
#endif
}
