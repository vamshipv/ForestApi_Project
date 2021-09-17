using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forestWeb
{
    public static class SD
    {
        // Url should match with WebApi Port number , that is forestApi
        public static string APIBaseUrl = "https://localhost:44345/";
        public static string NationalParkAPIPath = APIBaseUrl + "api/nationalparks/";
        public static string TrailAPIPath = APIBaseUrl + "api/trails/";
    }
}
