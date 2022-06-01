using System;
namespace scripting_final.Properties
{
    class Monster
    {
        #region Properties
        private string _Name;
        private float _Health;
        private float _Attack;
        private float _Defense;
        #endregion

        #region Getters and Setters
        public string Name
        {
            // get returns the value of a private property
            get { return this._Name; }
            // set updates the value of the private property to the given value
            set { this._Name = value; }
        }
        public float Health
        {
            get { return this._Health; }
            set { this._Health = value; }
        }

        public float Attack
        {
            get { return this._Attack; }
        }

        public float Defense
        {
            get { return this._Defense; }
        }
        #endregion

        #region Constructors

        public Monster(string name, float type)
        {
            this._Name = name;
            switch (type)
            {
                case 1:
                    this._Health = 100;
                    this._Attack = 15;
                    this._Defense = 90;
                    break;
                case 2:
                    this._Health = 50;
                    this._Attack = 35;
                    this._Defense = 95;
                    break;
                case 3:
                    this._Health = 200;
                    this._Attack = 6;
                    this._Defense = 75;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("OH NOOOOOOOO monster error");
                    Console.ResetColor();
                    break;
            }

        }

        public Monster(string name, float health, float attack)
        {
            this._Name = name;
            this._Health = health;
            this._Attack = attack;
        }
        #endregion
    }
}
