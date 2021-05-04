// usings come first, sorted by name, but with System usings at the very top
// Keep different namespace roots separated by an empty line

using System;
using System.Collections;

using Game;
using Game.Players;

using Wilder;

// next, each class should exist in a namespace, usually Game or a child of Game (Game.System, etc)
// Opening brackets { should exist alone on a new line
namespace Game
{
	// Classes should be indented in the namespace
	public class ExampleClass : MonoBehaviour
	{
		// All sections and subsections may be wrapped in #regions for easily readability
		// This is usefull in large classes, or classes with many different blocks of functionality.
		// All #region blocks below are optional, but recommended as your class becomes more complex
		// Use your best judgement for using #regions. If you only have two public fields, it probably isn't necessary to store them in a #region

		#region Constants
		// constants should come first, before any other variables or fields
		// constants should use UPPER_SNAKE_CASE, and be sorted in accessibility order (publics first, privates last)
		public const bool IS_ENABLED = false;

		// const may be substituted with `readonly static` if necessary, using the same naming schemes
		public readonly static Object EXAMPLE_READONLY_STATIC = new Object();
		
		// Fields of all types sorted in accessibility order may have optional empty lines between accessibility groups
		private const string EXAMPLE_CONSTANT_STRING = "example string";
		private readonly static Vector2 UP = new Vector2(0, 1);
		#endregion

		#region Statics
		// Static fields come next, using PascalCase
		public static string SceneName = "scene-name";
		#endregion

		#region Public Fields
		// public fields come first, at the top of your class, and use PascalCase naming
		public bool IsEnabled = false;
		#endregion

		#region Private Fields
		// private fields come next, under the public fields
		// private fields use _camelCase, always starting with an underscore
		private int _exampleInteger = 0;
		private string _exampleString = "";
		#endregion

		#region Properties
		// properties are next, in order of accessibility
		// Properties should always be PascalCase
		public bool ExampleProperty1 { get; private set; }
		public string ExampleProperty2 => _exampleInteger;

		private int ExampleProperty3 { get { return _exampleInteger; } }
		#endregion

		#region Events and Delegates
		// Delegates and Events come next, using PascalCase
		// Delegates should exist above their event counterparts if possible.
		// Related Delegates and Events should share names, with Delegates ending in "Handler" and Events ending in "Event"
		public delegate void OnExampleHandler();
		public event OnExampleHandler OnExampleEvent1;
		public event OnExampleHandler OnExampleEvent2;
		#endregion

		#region MonoBehaviour Methods
		// next, any MonoBehaviour (built-in Unity methods) above most other methods
		// The order of your MonoBehaviour methods should be in order-of-execution, as Unity would call them
		// Your OnEnable, Awake, Start methods would be at the top, with Update below, followed by OnDisable, OnDestroy, etc
		// These can optionally be wrapped in a `#region MonoBehaviour Methods` block for readability

		void Awake()
		{
			// code
		}

		void Start()
		{
			StartFunction1();
			// code
		}

		void Update()
		{
			UpdateExampleFunction1(true);
			UpdateExampleFunction2(false, 100);
			// code
		}

		void OnDisable()
		{
			// code
		}

		#endregion

		// The rest of your methods/functions come next.
		// Method names are CamelCase, and arguments (member variables) are camelCase
		// These should be listed in order of execution.
		private void StartFunction1()
		{
			// code
		}

		private void UpdateExampleFunction1(bool exampleArgument1)
		{
			// code
		}

		private void UpdateExampleFunction2(bool exampleArgument1, int exampleArgument2)
		{
			// code
		}

		// Coroutines come next. Couroutine names should use PascalCase, and should end with "Coroutine"
		public IEnumerator WaitForSecondsCoroutine()
		{
			yield return null;
		}

		// Optionally, complex or related blocks of code can come next, wrapped in #region blocks
		// These regions may each be styled the same way as a class, depending on complexity
		// Use your best judgement to tell if these #region blocks are necessary, and what whould be in them
		// A #region may contain only functions, or if complex enough, can contain other fields as well
		#region Player
		private Player _player;
		private Vector3 _playerPosition;

		public delegate void PlayerEventHandler();
		public event PlayerEventHandler OnPlayerJumpEvent;

		public void PlayerWalk()
		{
			// ..
		}

		public void PlayerJump()
		{
			// ..
		}
		#endregion
	}
}