#if UNITY_EDITOR
﻿using System.Collections;
using System.Collections.Generic;
using System;

namespace TNRD.Automatron {

    public class Converter {

        public static IList ArrayToList( Array array ) {
            var count = array.Length;
            var type = array.GetType().GetElementType();
            var list = (IList)Activator.CreateInstance( typeof( List<> ).MakeGenericType( type ) );
            for ( int i = 0; i < count; i++ ) {
                list.Add( array.GetValue( i ) );
            }
            return list;
        }

        public static Array ListToArray( IList list ) {
            var count = list.Count;
            var type = list.GetType().GetGenericArguments()[0];
            var array = Array.CreateInstance( type, count );
            for ( int i = 0; i < count; i++ ) {
                array.SetValue( list[i], i );
            }
            return array;
        }
    }
}
#endif