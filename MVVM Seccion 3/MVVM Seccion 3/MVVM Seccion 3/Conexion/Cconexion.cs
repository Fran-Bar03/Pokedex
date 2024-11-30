using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM_Seccion_3.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://pokedex-93e94-default-rtdb.firebaseio.com/");

    }
}
