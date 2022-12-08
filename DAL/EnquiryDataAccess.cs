using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace DAL
{
    public class EnquiryDataAccess
    {
        DatabaseContext db = new DatabaseContext();

        public List<Enquiry> GetAll()
        {
            return db.Enquiries.ToList();
        }
        public Enquiry GetById(int id)
        {
            return db.Enquiries.Find(id);
        }    
        public void Add(Enquiry enquiry)
        { 
                db.Enquiries.Add(enquiry);
                db.SaveChanges();
        }        
        public HttpResponseMessage Update(Enquiry enquiry)
        {
            try
            {              
                    db.Entry(enquiry).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                    return response;               
            }
            catch(Exception ex)
            {
                HttpResponseMessage responseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
                return responseMessage;
            }
        }
        public HttpResponseMessage Delete(int id)
        {
            Enquiry enquiry = db.Enquiries.Find(id);
            if(enquiry != null)
            {
                db.Enquiries.Remove(enquiry);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                return response;
            }
            else
            {
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                return response;
            }
        }
    }
}
