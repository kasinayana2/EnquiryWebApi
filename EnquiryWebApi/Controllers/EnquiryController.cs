using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BLL.BussinessObjects;

namespace EnquiryWebApi.Controllers
{
    public class EnquiryController : ApiController
    {
        EnquiryService es = new EnquiryService();

        public List<EnquiryBO> GetAll()
        {
            return es.GetAll();
        }
        [HttpGet]
        public EnquiryBO Edit(int id)
        {
            return es.GetById(id);
        }
        [HttpPost]
        public HttpResponseMessage Add(EnquiryBO enquiryBO)
        {
            try
            {
                es.Add(enquiryBO);
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
                return response;
            }
            catch(Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }            
        }
        [HttpPost]
        public HttpResponseMessage Edit(EnquiryBO enquiryBO)
        {
            try
            {
                es.Edit(enquiryBO);
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
                return response;
            }
        }
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                es.Delete(id);
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                return response;
            }
            catch(Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
                return response;
            }
        }
        


        //public Enquiry GetId(int id)
        //{
        //    return db.Enquiries.Find(id);
        //}
        //[HttpPost]
        //public HttpResponseMessage Adduser(Enquiry en)
        //{
        //    try
        //    {
        //        db.Enquiries.Add(en);
        //        db.SaveChanges();
        //        HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
        //        return response;
        //    }
        //    catch(Exception ex)
        //    {
        //        HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
        //        return response;
        //    }
        //}
        //[HttpPut]
        //public HttpResponseMessage UpdateUser(int id,Enquiry enquiry)
        //{
        //    try
        //    {
        //        if (id == enquiry.Id)
        //        {
        //            db.Entry(enquiry).State = System.Data.Entity.EntityState.Modified;
        //            db.SaveChanges();
        //            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
        //            return response;
        //        }
        //        else
        //        {
        //            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
        //            return response;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
        //        return response;
        //    }
        //}
        //public HttpResponseMessage DeleteUser(int id)
        //{
        //    Enquiry enquiry = db.Enquiries.Find(id);
        //    if (enquiry != null)
        //    {
        //        db.Enquiries.Remove(enquiry);
        //        db.SaveChanges();
        //        HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
        //        return response;
        //    }
        //    else
        //    {
        //        HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
        //        return response;
        //    }
        //}

    }
}
