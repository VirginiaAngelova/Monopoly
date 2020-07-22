using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Player
    {
        private string _namePlayer;
        private double _cash;
        private int _position;

        public Player(string firstName, int AmountOfMoney, int positionPlayer)
        { 
            this.NamePlayer = firstName;
            this.Cash = AmountOfMoney;
            this.Position = positionPlayer;

        }
        public string NamePlayer
        {
            get
            {
                return this._namePlayer;
            }
            set
            {
                this._namePlayer = value;
            }
        }

        public double Cash
        {
            get
            {
                return this._cash;
            }
            set
            {
                this._cash = value;
            }
        }

        public int Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }

        public void Move(int dice)
        {
            this.Position += dice;
        }

    }
}
