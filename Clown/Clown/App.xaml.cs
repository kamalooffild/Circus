using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Circus.Model;
using Clown.Model;

namespace Circus
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static circusKAMALOV326Entities1 DB = new circusKAMALOV326Entities1();
        public static Employee LoggedEmployee;
    }
}
