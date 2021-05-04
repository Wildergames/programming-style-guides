// usings come first, sorted by name
using System;

// next, each class should exist in a namespace, usually Game or a child of Game (Game.System, etc)
namespace Game
{
	// Classes should be indented in the namespace
	public class ExampleClass : MonoBehaviour
	{
		// public fields come first, at the top of your class, and use PascalCase naming
		public bool IsEnabled = false;

		// private fields come next, under the public fields
		// private fields use _camelCase, always starting with an underscore
		private int _exampleInteger = 0;
		private string _exampleString = "";

		// next, any MonoBehaviour (built-in Unity methods) above most other methods
		// The order of your MonoBehaviour methods should be in order-of-execution, as Unity would call them
		// Your OnEnable, Awake, Start methods would be at the top, with Update below, followed by OnDisable, OnDestroy, etc
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

		// Under your MonoBehaviour methods is where the rest of your methods/functions should go.
		// Method names are CamelCase, and arguments (member variables) are camelCase without underscores
		// These should be in order of execution, or as close as possible.
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
	}
}