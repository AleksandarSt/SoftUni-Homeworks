using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.GameEngine
{
    class AdditionalEngine:Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            throw new NotImplementedException();
        }

        protected override void AddItem(string[] inputParams)
        {
            throw new NotImplementedException();
        }
    }
}
