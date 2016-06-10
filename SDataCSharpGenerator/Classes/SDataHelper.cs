using Saleslogix.SData.Client;
using Saleslogix.SData.Client.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SDataCSharpGenerator.Classes
{
    public class SDataHelper
    {
        private SetupConfig _setup;
        private SDataClient _sdata;


        public SDataHelper(SetupConfig setup)
        {
            _setup = setup;

            _sdata = new SDataClient(_setup.SDataUrl)
            {
                UserName = _setup.Username,
                Password = _setup.Password
            };
        }

        public async Task<Dictionary<string, string>> GetResourceTypes()
        {
            Dictionary<string, string> resourceTypes = new Dictionary<string, string>();

            var param = new SDataParameters { Path = "$schema" };
            var results = await _sdata.ExecuteAsync<SDataSchema>(param);

            foreach(var resource in results.Content.ResourceTypes)
            {
                resourceTypes.Add(resource.Path, resource.ElementName);
            }

            return resourceTypes;

        }

        public void GetProperties(string resourceType)
        {

            var path = resourceType;
            if (!string.IsNullOrEmpty(path))
            {
                path += "/";
            }
            var template =  _sdata.Get("", path + "$template");

            var i = 0;

        }


        public void GetSchema(string resourceType)
        {
            
            var param = new SDataParameters { Path = "$schema" };
            var results = _sdata.Execute<SDataSchema>(param);

            foreach (var prop in results.Content.ResourceTypes[resourceType].ValueProperties)
            {
                
            }

        }



    }
}
