using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class ButtonHeal
    {
        NumericEventArgs _eventArgs = new NumericEventArgs();
        public int _healValue { get; set; }
        ButtonHeal(int healValue)
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
            ButtonHealAll(this, healValue as int);
        }
    }
}
