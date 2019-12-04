﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComandosYMenus
{
    public static class ComandosPersonalizados
    {


        public static readonly RoutedUICommand Vaciar = new RoutedUICommand(
            
            "Vaciar",
            "Vaciar",
            typeof(ComandosPersonalizados),
            new InputGestureCollection()
            {
                new KeyGesture(Key.V, ModifierKeys.Alt)
            }
            
            );

        public static readonly RoutedUICommand Exit = new RoutedUICommand(

                    "Exit",
                    "Exit",
                    typeof(ComandosPersonalizados),
                    new InputGestureCollection()
                    {
                new KeyGesture(Key.S, ModifierKeys.Control)
                    }

                    );
    }
}
