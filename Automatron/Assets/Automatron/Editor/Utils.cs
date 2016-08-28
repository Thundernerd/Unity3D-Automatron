namespace TNRD.Automatron {

    public static class Utils {

        public static string GetPrettyName( string name ) {
            var newName = "";

            for ( int i = 0; i < name.Length; i++ ) {
                var c = name[i];
                if ( i == 0 ) {
                    if ( char.IsLetter( c ) ) {
                        newName += char.ToUpper( c );
                    }
                } else if ( char.IsUpper( c ) ) {
                    if ( i + 1 < name.Length && !char.IsUpper( name[i + 1] ) ) {
                        newName += " ";
                        newName += c;
                    } else if ( !char.IsUpper( name[i - 1] ) ) {
                        newName += " ";
                        newName += c;
                    } else {
                        newName += c;
                    }
                } else if ( char.IsSymbol( c ) ) {
                    newName += " ";
                } else if ( char.IsNumber( c ) ) {
                    if ( char.IsNumber( name[i - 1] ) ) {
                        newName += c;
                    } else {
                        newName += " ";
                        newName += c;
                    }
                } else {
                    if ( string.IsNullOrEmpty( newName ) ) {
                        newName += char.ToUpper( c );
                    } else {
                        newName += c;
                    }
                }
            }

            return newName;
        }
    }
}