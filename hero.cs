using System;
namespace scripting_final
{
        class Hero
        {
            #region Private
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
            public Hero(string name, string type)
            {
                this._Name = Name;
                switch (type)
                {
                    case "Knight":
                        this._Health = 110;
                        this._Attack = 20;
                        this._Defense = 80;
                        break;
                    case "Assasin":
                        this._Health = 60;
                        this._Attack = 40;
                        this._Defense = 85;
                        break;
                    case "Tank":
                        this._Health = 150;
                        this._Attack = 10;
                        this._Defense = 70;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("OH NOOOOOOOO");
                        Console.ResetColor();
                        
                        break;
                }

            }

            public Hero(string Name, float Health, float Attack)
            {
                this._Name = Name;
                this._Health = Health;
                this._Attack = Attack;
            }
            #endregion
        }
    
}
