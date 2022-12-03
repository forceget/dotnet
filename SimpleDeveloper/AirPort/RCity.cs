﻿using RestSharp;
using SimpleDeveloper.InAndOutModel;
using State;
using System;
using System.Collections.Generic;
using System.Linq;

namespace City
{
    public class RCity 
    {

        public MCity.Root MultipleGet(MCity.FilterForm form)
        {
            MCity.Root rb = new MCity.Root();
            try
            {
                var client = new RestClient("https://localhost:44392/api/City/MultipleGet");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Bearer " + "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJiNDhjMjk0ZS01ODdjLTQ2YjUtOTk5ZC00NjQ3MDgwY2YzM2EiLCJqdGkiOiIyMWM3YWE3Mi00ZGQ0LTRkYTMtYTExOS1lMzJjNzAyYzc4MzAiLCJuYmYiOjE2Njg4NDk5NDIsImV4cCI6MTY3MTQ0MTk0MiwiaXNzIjoiaHR0cHM6Ly9mb3JjZWdldC5jb20vIiwiYXVkIjoiZGV2In0.wb5OGXbVHy6m2038VUaCtcAnWwjS4ftT2eD89VuOxLU");
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);
                request.AddParameter("Search", form.Search);

                var response = client.Execute<MCity.Response>(request);

                //rb = response.Data;


                return rb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
