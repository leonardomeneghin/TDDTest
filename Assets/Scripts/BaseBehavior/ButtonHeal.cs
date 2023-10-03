using Assets.Scripts.BaseBehavior.EventHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class ButtonHeal
    {
        public int _healValue { get; set; }
        public ButtonHeal() { }
        public ButtonHeal(int healValue)
        {
            _healValue = healValue;
        }
        //Delegate
        public delegate void ButtonHealAllEventHandler(object sender, EventArgs args);

        //Adicionar ao evento (match delegate)
        public event ButtonHealAllEventHandler ButtonHealAll;

        //Lista de observadores de si mesma
        List<EventHandler> eventHandlers = new List<EventHandler>();
        public void AddListener(EventHandler handler)
        {
            eventHandlers.Add(handler);
        }

        public void OnClickHeal()
        {
            var healValue = 1;
            //Emitir o evento de que realizou a cura + Realizar a cura
            //BUG01: ButtonHealAll não possui ouvintes, necessário configurar
            ButtonHealAll(this, new NumericEventArgs(healValue));
        }

    }
}
