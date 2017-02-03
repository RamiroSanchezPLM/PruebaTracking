using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCronner
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    //Comentarios para el branch de testing, agregando
    public class Cronner : ICronner
    {

        public static void main(string[] args)
        {
            System.Console.Out.WriteLine("Se empieza a ejecutar...");
            
            s.inicia();
            
            System.Console.ReadLine();
        }

        public void inicia()
        {
            // Prepare countries timer:
            this._countriesTimer = new System.Timers.Timer();
            this._countriesTimer.Interval = 5000;
            this._countriesTimer.Elapsed += new System.Timers.ElapsedEventHandler(_countriesTimer_Elapsed);

        }

        public void getCountries()
        {
            c = new PruebaCronnerBusinessLogicComponent.PLMClientsEngine.PLMClientsClient();
            c.getCountriesCompleted +=
                new EventHandler<PruebaCronnerBusinessLogicComponent.PLMClientsEngine.getCountriesCompletedEventArgs>(getCountriesCompleted);
            
        }

        public void getCountriesCompleted(object sender, PruebaCronnerBusinessLogicComponent.PLMClientsEngine.getCountriesCompletedEventArgs e)
        {
            if (e.Error == null)
                this._mensajito = "exitoso";
            else
                this._mensajito = "falló";

            this._semaphore = 0;
        }

        public void _countriesTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this._semaphore == 0)
            {
                // Take critical section:
                this._semaphore = 1;

                try
                {
                    // Get logs from local database:
                    List<PruebaCronnerBusinessLogicComponent.PLMClientsEngine.CountryInfo> countries =  c.getCountries();
                    this._semaphore = 0;
                }
                catch
                {
                    this._semaphore = 0;
                }
            }
        }

        PruebaCronnerBusinessLogicComponent.PLMClientsEngine.PLMClientsClient c;

        public System.Timers.Timer _countriesTimer;

        private int _semaphore = 0;
        private string _mensajito;

        public static readonly Cronner s = new Cronner();

    }
    
}
