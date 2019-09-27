using System;

/// <summary>
/// NOMBRE: Builder.
/// 
/// DESCRIPCION: .
/// 
/// PATRON EXPERT: .
/// 
/// SRP: .
/// 
/// COLABORACIONES: Colabora con la clase World y hereda de IBuilder ya que debe conocer un objeto de tipo World.
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

        public void Build(IMainViewAdapter adapter);

    }
}
