using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Net.Http;
using System;
using NLog;

namespace HelloAssetAdministrationShell
{
     public class GERVALUE
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
      public async Task< timeseriesdata[]> GETval()
    {
        string url = "http://10.2.14.188:3000/Temperature/history";
      
       
        HttpClient piclient = new HttpClient(); 
        try
        {
            var  data = await piclient.GetAsync(url);
            string JsonPidata = await data.Content.ReadAsStringAsync();
             var dataobject = JsonConvert.DeserializeObject<timeseriesdata[]>(JsonPidata);
            logger.Info("Data has been collected ");
          
         return dataobject;
}            
       
        catch 
        {
             logger.Info("Connection could not be made");
          
            return null;
           
        }        
          
    }     

    }
}   
