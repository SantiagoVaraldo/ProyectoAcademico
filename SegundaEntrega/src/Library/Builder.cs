using System;
using Proyecto.StudentsCode;

/// <summary>
/// NOMBRE: Builder.
/// 
/// DESCRIPCION: .
/// 
/// PATRON EXPERT: .
/// 
/// SRP: .
/// 
/// COLABORACIONES: Colabora con la clase World ya que debe conocer un objeto de tipo World y es de tipo IBuilder.
/// </summary>

namespace Library
{
    public class Builder : IBuilder
    {
        public Builder(World world)
        {
            this.world = world;
        }
        private World world;

        public void Build(IMainViewAdapter adapter)
        {

        }

    }
}
