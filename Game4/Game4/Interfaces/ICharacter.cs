﻿using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

namespace RPGGame.Interfaces
{
    public interface ICharacter : IAttack, IDefence
    {
        #region Properties

        double X { get; }
        double Y { get; }
        Texture2D Pic { get; }
        double Life { get; }
        Ability MyAbility { get; }
        float Elapsed { get; }
        int Frame { get; }
        float Delay { get; }
        string Pos { get; }
        int Damage { get; }
        float Speed { get; }
        int Focus { get; }
        int Energy { get; }
        int Coffeine { get; }

        #endregion
    }
}
