using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental;

/// <summary>
/// VR input for OpenVR https://docs.unity3d.com/Manual/OpenVRControllers.html
/// Note: Will create new entries for Unity's input manager.
/// </summary>

namespace VRI {
	public class VRInput : MonoBehaviour {

		public static VRInput Instance {
			get;
			private set;
		}

		[Range(.1f, .95f)]
		public float triggerDownThreshold = .7f;
		[Range(.05f, .9f)]
		public float triggerUpThreshold = .5f;
		public bool showValues = false;

		private Button leftMenu = new Button();
		private Button rightMenu = new Button();
		private Button leftPadPress = new Button();
		private Button rightPadPress = new Button();
		private Button leftPadTouch = new Button();
		private Button rightPadTouch = new Button();
		//Vector2 Left Touch
		//Vector2 Right Touch
		private Button leftTrigger = new Button();
		private Button rightTrigger = new Button();
		//Float Left Trigger
		//Float Right Trigger
		private Button leftGrip = new Button();
		private Button rightGrip = new Button();

		#region Left Menu Button
		public static bool LeftMenuDown {
			get {
				return Instance.leftMenu.down;
			}
		}
		public static bool LeftMenu {
			get {
				return Input.GetButton("Left Menu");
			}
		}
		public static bool LeftMenuUp {
			get {
				return Instance.leftMenu.up;
			}
		}
		#endregion

		#region Right Menu Button
		public static bool RightMenuDown {
			get {
				return Instance.rightMenu.down;
			}
		}
		public static bool RightMenu {
			get {
				return Input.GetButton("Right Menu");
			}
		}
		public static bool RightMenuUp {
			get {
				return Instance.rightMenu.up;
			}
		}
		#endregion

		#region Left Pad Press
		public static bool LeftPadPressDown {
			get {
				return Instance.leftPadPress.down;
			}
		}
		public static bool LeftPadPress {
			get {
				return Input.GetButton("Left Pad Press");
			}
		}
		public static bool LeftPadPressUp {
			get {
				return Instance.leftPadPress.up;
			}
		}
		#endregion

		#region Right Pad Press
		public static bool RightPadPressDown {
			get {
				return Instance.rightPadPress.down;
			}
		}
		public static bool RightPadPress {
			get {
				return Input.GetButton("Right Pad Press");
			}
		}
		public static bool RightPadPressUp {
			get {
				return Instance.rightPadPress.up;
			}
		}
		#endregion

		#region Left Pad Touch
		public static bool LeftPadTouchDown {
			get {
				return Instance.leftPadTouch.down;
			}
		}
		public static bool LeftPadTouch {
			get {
				return Input.GetButton("Left Pad Touch");
			}
		}
		public static bool LeftPadTouchUp {
			get {
				return Instance.leftPadTouch.up;
			}
		}
		#endregion

		#region Right Pad Touch
		public static bool RightPadTouchDown {
			get {
				return Instance.rightPadTouch.down;
			}
		}
		public static bool RightPadTouch {
			get {
				return Input.GetButton("Right Pad Touch");
			}
		}
		public static bool RightPadTouchUp {
			get {
				return Instance.rightPadTouch.up;
			}
		}
		#endregion

		#region Pad Axis
		public static Vector2 LeftTouchPad {
			get {
				return new Vector2(Input.GetAxis("Left Vertical"), Input.GetAxis("Left Horizontal"));
			}
		}
		public static Vector2 RightTouchPad {
			get {
				return new Vector2(Input.GetAxis("Right Vertical"), Input.GetAxis("Left Horizontal"));
			}
		}
		#endregion

		#region Trigger Magnitudes
		public static float LeftTriggerMagnitude {
			get {
				return Input.GetAxis("Left Trigger");
			}
		}
		public static float RightTriggerMagnitude {
			get {
				return Input.GetAxis("Right Trigger");
			}
		}
		#endregion

		#region Left Trigger
		public static bool LeftTriggerDown {
			get {
				return Instance.leftTrigger.down;
			}
		}
		public static bool LeftTrigger {
			get {
				return Input.GetAxis("Left Trigger") > Instance.triggerDownThreshold ? true : false;
			}
		}
		public static bool LeftTriggerUp {
			get {
				return Instance.leftTrigger.up;
			}
		}
		#endregion

		#region Right Trigger
		public static bool RightTriggerDown {
			get {
				return Instance.rightTrigger.down;
			}
		}
		public static bool RightTrigger {
			get {
				return Input.GetAxis("Right Trigger") > Instance.triggerDownThreshold ? true : false;
			}
		}
		public static bool RightTriggerUp {
			get {
				return Instance.rightTrigger.up;
			}
		}
		#endregion

		#region Left Grip
		public static bool LeftGripDown {
			get {
				return Instance.leftGrip.down;
			}
		}
		public static bool LeftGrip {
			get {
				return Input.GetButton("Left Grip");
			}
		}
		public static bool LeftGripUp {
			get {
				return Instance.leftGrip.up;
			}
		}
		#endregion

		#region Right Grip
		public static bool RightGripDown {
			get {
				return Instance.rightGrip.down;
			}
		}
		public static bool RightGrip {
			get {
				return Input.GetButton("Right Grip");
			}
		}
		public static bool RightGripUp {
			get {
				return Instance.rightGrip.up;
			}
		}
		#endregion


		private void Start() {
			if (Instance != this) {
				Destroy(gameObject);
			}
		}

		private void Update() {
			#region Reset Up/Down
			leftMenu.down = false;
			leftMenu.up = false;

			rightMenu.down = false;
			rightMenu.up = false;

			leftPadPress.down = false;
			leftPadPress.up = false;

			rightPadPress.down = false;
			rightPadPress.up = false;

			leftPadTouch.down = false;
			leftPadTouch.up = false;

			rightPadTouch.down = false;
			rightPadTouch.up = false;

			leftTrigger.down = false;
			leftTrigger.up = false;

			rightTrigger.down = false;
			rightTrigger.up = false;

			leftGrip.down = false;
			leftGrip.up = false;

			rightGrip.down = false;
			rightGrip.up = false;
			#endregion


			#region Set Up/Down
			if (Input.GetButtonDown("Left Menu")) {
				Debug.Log("DOWMNING");
				leftMenu.down = true;
			}
			if (Input.GetButtonUp("Left Menu"))
				leftMenu.up = true;

			if (Input.GetButtonDown("Right Menu"))
				rightMenu.down = true;
			if (Input.GetButtonUp("Right Menu"))
				rightMenu.up = true;

			if (Input.GetButtonDown("Left Pad Press"))
				leftPadPress.down = true;
			if (Input.GetButtonUp("Left Pad Press"))
				leftPadPress.up = true;

			if (Input.GetButtonDown("Right Pad Press"))
				rightPadPress.down = true;
			if (Input.GetButtonUp("Right Pad Press"))
				rightPadPress.up = true;

			if (Input.GetButtonDown("Left Pad Touch"))
				leftPadTouch.down = true;
			if (Input.GetButtonUp("Left Pad Touch"))
				leftPadTouch.up = true;

			if (Input.GetButtonDown("Right Pad Touch"))
				rightPadTouch.down = true;
			if (Input.GetButtonDown("Right Pad Touch"))
				rightPadTouch.up = true;

			if (Input.GetAxis("Left Trigger") > triggerDownThreshold)
				leftTrigger.down = true;
			if (Input.GetAxis("Left Trigger") < triggerUpThreshold)
				leftTrigger.up = true;

			if (Input.GetAxis("Right Trigger") > triggerDownThreshold)
				rightTrigger.down = true;
			if (Input.GetAxis("Right Trigger") < triggerUpThreshold)
				rightTrigger.up = true;

			if (Input.GetButtonDown("Left Grip"))
				leftGrip.down = true;
			if (Input.GetButtonUp("Left Grip"))
				leftGrip.up = true;

			if (Input.GetButtonDown("Right Grip"))
				rightGrip.down = true;
			if (Input.GetButtonUp("Right Grip"))
				rightGrip.up = true;
			#endregion

		}

		#region Show debug values
		private void OnGUI() {
			if (showValues) {
				Rect rect = new Rect(0, 0, 400, 30);
				GUILayout.BeginHorizontal();
				GUILayout.BeginVertical();
				////
				GUILayout.TextArea(LeftMenuDown.ToString());
				GUILayout.TextArea(LeftMenu.ToString());
				GUILayout.TextArea(LeftMenuUp.ToString());

				GUILayout.TextArea(LeftPadPressDown.ToString());
				GUILayout.TextArea(LeftPadPress.ToString());
				GUILayout.TextArea(LeftPadPressUp.ToString());

				GUILayout.TextArea(LeftPadTouchDown.ToString());
				GUILayout.TextArea(LeftPadTouch.ToString());
				GUILayout.TextArea(LeftPadTouchUp.ToString());

				GUILayout.TextArea(LeftTouchPad.ToString());

				GUILayout.TextArea(LeftTriggerMagnitude.ToString());

				GUILayout.TextArea(LeftTriggerDown.ToString());
				GUILayout.TextArea(LeftTrigger.ToString());
				GUILayout.TextArea(LeftTriggerUp.ToString());

				GUILayout.TextArea(LeftGripDown.ToString());
				GUILayout.TextArea(LeftGrip.ToString());
				GUILayout.TextArea(LeftGripUp.ToString());

				GUILayout.EndVertical();
				GUILayout.BeginVertical();
				////
				GUILayout.TextArea(RightMenuDown.ToString());
				GUILayout.TextArea(RightMenu.ToString());
				GUILayout.TextArea(RightMenuUp.ToString());

				GUILayout.TextArea(RightPadPressDown.ToString());
				GUILayout.TextArea(RightPadPress.ToString());
				GUILayout.TextArea(RightPadPressUp.ToString());

				GUILayout.TextArea(RightPadTouchDown.ToString());
				GUILayout.TextArea(RightPadTouch.ToString());
				GUILayout.TextArea(RightPadTouchUp.ToString());

				GUILayout.TextArea(RightTouchPad.ToString());

				GUILayout.TextArea(RightTriggerMagnitude.ToString());

				GUILayout.TextArea(RightTriggerDown.ToString());
				GUILayout.TextArea(RightTrigger.ToString());
				GUILayout.TextArea(RightTriggerUp.ToString());

				GUILayout.TextArea(RightGripDown.ToString());
				GUILayout.TextArea(RightGrip.ToString());
				GUILayout.TextArea(RightGripUp.ToString());

				GUILayout.EndVertical();
				GUILayout.EndHorizontal();

			}
		}
		#endregion

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Load() {
			GameObject manager = (GameObject)Resources.Load("VRInput");
			if (manager != null) {
				Instance = Instantiate(manager).GetComponent<VRInput>();
				if (Instance != null) {
					DontDestroyOnLoad(Instance.gameObject);
					Instance.gameObject.name = "VRInput";
					Instance.RegisterInputs();
				}
			}
		}

		[ContextMenu("Populate input manager now")]
		public void RegisterInputs() {
#if UNITY_EDITOR
			var inputEntries = new List<InputManagerEntry> {
			new InputManagerEntry { name = "Left Menu",         kind = InputManagerEntry.Kind.KeyOrButton,  btnPositive = "joystick button 2" },
			new InputManagerEntry { name = "Right Menu",        kind = InputManagerEntry.Kind.KeyOrButton,  btnPositive = "joystick button 0" },
			new InputManagerEntry { name = "Left Pad Press",    kind = InputManagerEntry.Kind.KeyOrButton,  btnPositive = "joystick button 8" },
			new InputManagerEntry { name = "Right Pad Press",   kind = InputManagerEntry.Kind.KeyOrButton,  btnPositive = "joystick button 9" },
			new InputManagerEntry { name = "Left Pad Touch",    kind = InputManagerEntry.Kind.KeyOrButton,  btnPositive = "joystick button 16" },
			new InputManagerEntry { name = "Right Pad Touch",   kind = InputManagerEntry.Kind.KeyOrButton,  btnPositive = "joystick button 17" },
			new InputManagerEntry { name = "Left Horizontal",   kind = InputManagerEntry.Kind.Axis,         axis = InputManagerEntry.Axis.X },
			new InputManagerEntry { name = "Left Vertical",     kind = InputManagerEntry.Kind.Axis,         axis = InputManagerEntry.Axis.Y },
			new InputManagerEntry { name = "Right Horizontal",  kind = InputManagerEntry.Kind.Axis,         axis = InputManagerEntry.Axis.Fifth,    gravity = 1000f, deadZone = 0.001f, sensitivity = 1000f},
			new InputManagerEntry { name = "Right Vertical",    kind = InputManagerEntry.Kind.Axis,         axis = InputManagerEntry.Axis.Sixth,    gravity = 1000f, deadZone = 0.001f, sensitivity = 1000f},
			new InputManagerEntry { name = "Left Trigger",      kind = InputManagerEntry.Kind.Axis,         axis = InputManagerEntry.Axis.X + 8,    gravity = 1000f, deadZone = 0.001f, sensitivity = 1000f},
			new InputManagerEntry { name = "Right Trigger",     kind = InputManagerEntry.Kind.Axis,         axis = InputManagerEntry.Axis.X + 9,    gravity = 1000f, deadZone = 0.001f, sensitivity = 1000f},
			new InputManagerEntry { name = "Left Grip",         kind = InputManagerEntry.Kind.Axis,         axis = InputManagerEntry.Axis.X + 10,   gravity = 1000f, deadZone = 0.001f, sensitivity = 1000f},
			new InputManagerEntry { name = "Right Grip",        kind = InputManagerEntry.Kind.Axis,         axis = InputManagerEntry.Axis.X + 11,   gravity = 1000f, deadZone = 0.001f, sensitivity = 1000f},
		};
			InputRegistering.RegisterInputs(inputEntries);
#endif
		}

	}

	public sealed class Button {
		public bool up = false;
		public bool down = false;
	}

}
