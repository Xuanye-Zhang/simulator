/**
 * Copyright (c) 2019-2021 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using UnityEngine;
using UnityEditor;

namespace Simulator.Map
{
    public class MapSign : MapData, IMapType
    {
        public SignType signType;
        public MapLine stopLine;

        public Vector3 boundOffsets = new Vector3(); // TODO
        public Vector3 boundScale = new Vector3();
        [System.NonSerialized]
        public Renderer signMesh;

        [SerializeField] 
        private string _id;
        public string id
        {
            get { return _id; }
            set
            {
#if UNITY_EDITOR
                Undo.RecordObject(this, $"Changed MapSign ID");
#endif
                _id = value;
            }
        }

#region UniqueIdGeneration

        // Prefix used during auto id generation.
        [System.NonSerialized]
        public static string idPrefix = "stop_sign_";

#if UNITY_EDITOR

        // Autoassign id for a newely created item.
        private void Reset()
        {
            var mapHolder = UnityEngine.Object.FindObjectOfType<MapHolder>();
            id = IdGenerator.AutogenerateNextId<MapSign>(idPrefix);
        }

        [InitializeOnLoadMethod]
        static void Initialize()
        {
            UnityEditor.SceneManagement.EditorSceneManager.sceneOpened += OnEditorSceneManagerSceneOpened;
        }

        // When scene is opened, go over all objects of same type and assign ids if missing.
        static void OnEditorSceneManagerSceneOpened(UnityEngine.SceneManagement.Scene scene, UnityEditor.SceneManagement.OpenSceneMode mode)
        {
            var mapHolder = UnityEngine.Object.FindObjectOfType<MapHolder>();
            if (mapHolder == null)
                return;

            // If there is no ID set, set autogenerated ones.
            foreach (var sign in mapHolder.transform.GetComponentsInChildren<MapSign>())
            {
                if(string.IsNullOrEmpty(sign.id))
                    sign.id = IdGenerator.AutogenerateNextId<MapSign>(idPrefix);
            }
        }
#endif
#endregion

        public override void Draw()
        {
            var start = transform.position;
            var end = start + transform.up * 2f;

            AnnotationGizmos.DrawWaypoint(transform.position, MapAnnotationTool.WAYPOINT_SIZE * 0.5f, stopSignColor + selectedColor);
            Gizmos.color = stopSignColor + selectedColor;
            Gizmos.DrawLine(start, end);
            AnnotationGizmos.DrawArrowHead(start, end, stopSignColor + selectedColor, arrowHeadScale: MapAnnotationTool.ARROWSIZE, arrowPositionRatio: 1f);
            if (MapAnnotationTool.SHOW_HELP)
            {
#if UNITY_EDITOR
                UnityEditor.Handles.Label(transform.position, "    " + signType + " SIGN");
#endif
            }

            if (stopLine != null)
            {
                Gizmos.color = Color.magenta;
                Gizmos.DrawLine(transform.position, stopLine.transform.position);
                AnnotationGizmos.DrawArrowHead(transform.position, stopLine.transform.position, Color.magenta, arrowHeadScale: MapAnnotationTool.ARROWSIZE, arrowPositionRatio: 1f);
                if (MapAnnotationTool.SHOW_HELP)
                {
#if UNITY_EDITOR
                    UnityEditor.Handles.Label(stopLine.transform.position, "    STOPLINE");
#endif
                }
            }

            // bounds need offset
            Gizmos.matrix = transform.localToWorldMatrix * Matrix4x4.TRS(boundOffsets, Quaternion.identity, Vector3.Scale(Vector3.one, boundScale));
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
            if (MapAnnotationTool.SHOW_HELP)
            {
#if UNITY_EDITOR
                UnityEditor.Handles.Label(transform.position + Vector3.up, "    SIGNAL BOUNDS");
#endif
            }
        }
    }
}