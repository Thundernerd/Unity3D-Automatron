using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Array/Get Length" )]
	class ArrayGetLength0 : Automation {

		public System.Array Instance;
		public System.Int32 dimension;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetLength(dimension);
			yield break;
		}

	}

	[Automation( "Array/Get Long Length" )]
	class ArrayGetLongLength1 : Automation {

		public System.Array Instance;
		public System.Int32 dimension;
		[ReadOnly]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetLongLength(dimension);
			yield break;
		}

	}

	[Automation( "Array/Get Lower Bound" )]
	class ArrayGetLowerBound2 : Automation {

		public System.Array Instance;
		public System.Int32 dimension;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetLowerBound(dimension);
			yield break;
		}

	}

	[Automation( "Array/Get Upper Bound" )]
	class ArrayGetUpperBound3 : Automation {

		public System.Array Instance;
		public System.Int32 dimension;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetUpperBound(dimension);
			yield break;
		}

	}

	[Automation( "Array/Get Value" )]
	class ArrayGetValue4 : Automation {

		public System.Array Instance;
		public System.Int32 index;
		[ReadOnly]
		public System.Object Result;

		public override IEnumerator Execute() {
			Result = Instance.GetValue(index);
			yield break;
		}

	}

	[Automation( "Array/Set Value" )]
	class ArraySetValue5 : Automation {

		public System.Array Instance;
		public System.Object value;
		public System.Int32 index;

		public override IEnumerator Execute() {
			Instance.SetValue(value,index);
			yield break;
		}

	}

	[Automation( "Array/Create Instance" )]
	class ArrayCreateInstance6 : Automation {

		public System.Type elementType;
		public System.Int32 length;
		[ReadOnly]
		public System.Array Result;

		public override IEnumerator Execute() {
			Result = System.Array.CreateInstance(elementType,length);
			yield break;
		}

	}

	[Automation( "Array/Binary Search" )]
	class ArrayBinarySearch7 : Automation {

		public System.Array array;
		public System.Object value;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.Array.BinarySearch(array,value);
			yield break;
		}

	}

	[Automation( "Array/Copy" )]
	class ArrayCopy8 : Automation {

		public System.Array sourceArray;
		public System.Array destinationArray;
		public System.Int32 length;

		public override IEnumerator Execute() {
			System.Array.Copy(sourceArray,destinationArray,length);
			yield break;
		}

	}

	[Automation( "Array/Index Of" )]
	class ArrayIndexOf9 : Automation {

		public System.Array array;
		public System.Object value;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.Array.IndexOf(array,value);
			yield break;
		}

	}

	[Automation( "Array/Last Index Of" )]
	class ArrayLastIndexOf10 : Automation {

		public System.Array array;
		public System.Object value;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.Array.LastIndexOf(array,value);
			yield break;
		}

	}

	[Automation( "Array/Reverse" )]
	class ArrayReverse11 : Automation {

		public System.Array array;

		public override IEnumerator Execute() {
			System.Array.Reverse(array);
			yield break;
		}

	}

	[Automation( "Array/Sort" )]
	class ArraySort12 : Automation {

		public System.Array array;

		public override IEnumerator Execute() {
			System.Array.Sort(array);
			yield break;
		}

	}


#pragma warning restore 0649
}
