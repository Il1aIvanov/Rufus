using UnityEngine;
using System.Collections;

namespace Assets
{

    public class ChapterSettings : MonoBehaviour
    {
        public static int GetLastChapter { get { return PlayerPrefs.GetInt("LastChapter, 2"); } }

        public static void SetLastChapter(int value)
        {
            PlayerPrefs.SetInt("LastChapter", value);
        }
    }
}
