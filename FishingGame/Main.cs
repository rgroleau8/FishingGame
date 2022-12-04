using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using FishingGame.FishingMethods;

namespace FishingGame
{
    public class Main
    {
        public static void StartProgram()
        {
            var container = ContainerConfig.Configure();


            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IGameLogic>();
                app.StartGame();


            }

           
        }

        
    }
}
