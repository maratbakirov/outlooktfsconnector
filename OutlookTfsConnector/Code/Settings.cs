using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTfsConnector.Code
{
    public class TfsConfigurationItem : ICloneable
    {
        public string TfsUrl { get; set; }
        public string TfsProject { get; set; } 
        public string TfsUserName { get; set; }
        public string TfsUserToken { get; set; }

        public TfsConfigurationItem(
            string TfsUrl = "",
            string TfsProject = "",
            string TfsUserName = "",
            string TfsUserToken = ""
            )
        {
            this.TfsUrl = TfsUrl;
            this.TfsProject = TfsProject;
            this.TfsUserName = TfsUserName;
            this.TfsUserToken = TfsUserToken;
        }

        public object Clone()
        {
            var result = new TfsConfigurationItem();
            result.TfsUrl = this.TfsUrl;
            result.TfsProject = this.TfsProject;
            result.TfsUserName = this.TfsUserName;
            result.TfsUserToken = this.TfsUserToken;
            return result;
        }
    }
    public class Settings
    {
        public string RegexToParseEmailSubjects = "";
        public List<TfsConfigurationItem> TfsConfigurations = new List<TfsConfigurationItem>()  { new TfsConfigurationItem() };

        public void Load()
        {
            //TODO: load from registry
            TfsConfigurations[0].TfsUrl = ConfigurationManager.AppSettings["TFS_URL"];
            TfsConfigurations[0].TfsProject = ConfigurationManager.AppSettings["TFS_PROJECT"];
            TfsConfigurations[0].TfsUserName = ConfigurationManager.AppSettings["TFS_USERNAME"];
            TfsConfigurations[0].TfsUserToken = ConfigurationManager.AppSettings["TFS_USERTOKEN"];
        }

        public void Save()
        {
            //TODO: save to registry
        }
    }
}
