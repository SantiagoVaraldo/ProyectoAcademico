using System;

/// <summary>
/// NOMBRE: Sound.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer el path de un sonido.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para añadir un sonido a un elemento.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de sonido, su unica razon de cambio es modificar los datos que guardamos sobre un sonido.
/// 
/// NOTAS: En el futuro esta clase sera un componente de la clase Button el cual permitira añadir
/// sonidos a la accion de un boton.
/// </summary>

namespace Library
{
    public class Sound
    {
        public Sound(string SoundPath)
        {
            this.SoundPath = SoundPath;
        }
        private string soundpath;
        public string SoundPath
        {
            get
            {
                return this.soundpath;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.soundpath = value;
                }
            }
        }

    }
}