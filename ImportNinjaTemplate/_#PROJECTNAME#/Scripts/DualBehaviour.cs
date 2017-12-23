using System.IO;
using UnityEditor;
using UnityEngine;

public class DualBehaviour : MonoBehaviour
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    protected virtual void Awake()
    {
        Init();
    }

    protected virtual void Reset()
    {
        Init();
    }

    #endregion

    #region Class Methods

	[ContextMenu("Generate Editor for this script")]
	private void _GenerateEditor()
	{
        DirectoryInfo projectDirectory = Directory.GetParent(Application.dataPath);
        string projectPath = Application.dataPath + "/_" + projectDirectory.Name;

        // Didn't find a way to locate children class location using StackTrace, only DualBehaviours'
        // Could theoretically find it using its classname and search for its name in the Asset folder

        string name = this.GetType().Name;

        Directory.CreateDirectory(projectPath);
        Directory.CreateDirectory(projectPath + "/Editor");

        // TODO: Create the Editor file here

        AssetDatabase.Refresh();
    }


    private void Init()
    {
        if(m_transform == null)
            m_transform = GetComponent<Transform>();
    }


    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    [SerializeField]
    protected Transform m_transform;

    #endregion
}
