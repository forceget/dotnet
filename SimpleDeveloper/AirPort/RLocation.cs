﻿using City;
using RestSharp;
using SimpleDeveloper.InAndOutModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Location
{
    public class RLocation : ILocation
    {

        public ResponseBase<List<MLocation.Root>> MultipleGet(MLocation.FilterForm form)
        {
            ResponseBase<List<MLocation.Root>> rb = new ResponseBase<List<MLocation.Root>>();
            try
            {
                var client = new RestClient("https://localhost:44392/api/Location/Search");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Bearer " + "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJiNDhjMjk0ZS01ODdjLTQ2YjUtOTk5ZC00NjQ3MDgwY2YzM2EiLCJqdGkiOiIyMWM3YWE3Mi00ZGQ0LTRkYTMtYTExOS1lMzJjNzAyYzc4MzAiLCJuYmYiOjE2Njg4NDk5NDIsImV4cCI6MTY3MTQ0MTk0MiwiaXNzIjoiaHR0cHM6Ly9mb3JjZWdldC5jb20vIiwiYXVkIjoiZGV2In0.wb5OGXbVHy6m2038VUaCtcAnWwjS4ftT2eD89VuOxLU");
                request.AddParameter("Sort.Column", form.Sort.Column);
                request.AddParameter("Take", form.Take);
                request.AddParameter("Sort.Type", form.Sort.Type);
                request.AddParameter("Offset", form.Offset);
                request.AddParameter("LocationTypes", form.LocationTypes);
                request.AddParameter("Search", form.Search);

                var response = client.Execute<MLocation.Root>(request);
                var data = response.Data.item.Select(x => x.name).ToList();
                //rb.Item = data;
                return rb;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
