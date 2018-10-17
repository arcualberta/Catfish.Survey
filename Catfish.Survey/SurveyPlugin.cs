using Catfish.Core.Plugins;
using Piranha.WebPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Catfish.Survey
{
    public class SurveyPlugin : Plugin
    {
        public override void Initialize()
        {
            InitializeManagerViews();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            
        }

        private void InitializeManagerViews()
        {
            var menubar = Manager.Menu.Where(m => m.InternalId == "Settings").FirstOrDefault();

            menubar.Items.Insert(1, new Manager.MenuItem()
            {
                Name = "Ingest Forms",
                Action = "Index",
                Controller = "FormIngestion",
                Permission = "ADMIN_CONTENT",
            });

            AreaRegistration.RegisterAllAreas();
        }

        public virtual void RegisterArea(AreaRegistrationContext context)
        {
            context.Namespaces.Add("Catfish.Survey");
        }
    }
}
