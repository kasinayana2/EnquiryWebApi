using BLL.BussinessObjects;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EnquiryService
    {
        EnquiryDataAccess eda = new EnquiryDataAccess();
        public List<EnquiryBO> GetAll()
        {
            List<Enquiry> getallEnquiries = eda.GetAll();
            List<EnquiryBO> getallEnqBOList = new List<EnquiryBO>();
            foreach (Enquiry enquiry in getallEnquiries)
            {
                EnquiryBO enquiryBO = new EnquiryBO();
                enquiryBO.Address = enquiry.Address;
                enquiryBO.Age = enquiry.Age;
                enquiryBO.FristName = enquiry.FristName;
                enquiryBO.Id = enquiry.Id;
                enquiryBO.LastName = enquiry.LastName;
                getallEnqBOList.Add(enquiryBO);
            }
            return getallEnqBOList;
        }
        public EnquiryBO GetById(int id)
        {
            Enquiry enquiry = new Enquiry();
            enquiry = eda.GetById(id);
            EnquiryBO enquiryBO = new EnquiryBO();
            enquiryBO.Address = enquiry.Address;
            enquiryBO.Age = enquiry.Age;
            enquiryBO.FristName = enquiry.FristName;
            enquiryBO.Id = enquiry.Id;
            enquiryBO.LastName = enquiry.LastName;
            return enquiryBO;
        }
        public void Add(EnquiryBO enquiryBO)
        {
            Enquiry enquiry = new Enquiry();
            enquiry.Address = enquiryBO.Address;
            enquiry.Age = enquiryBO.Age;
            enquiry.FristName = enquiryBO.FristName;
            enquiry.LastName = enquiryBO.LastName;
            enquiry.Id = enquiryBO.Id;
            eda.Add(enquiry);
        }
        public void Edit(EnquiryBO enquireyBO)
        {
            Enquiry enquiry = new Enquiry();
            enquiry = eda.GetById(enquireyBO.Id);
            enquiry.Address = enquireyBO.Address;
            enquiry.Age = enquireyBO.Age;
            enquiry.FristName = enquireyBO.FristName;
            enquiry.LastName = enquireyBO.LastName;
             eda.Update(enquiry);
        }
        public void Delete(int id)
        {
            eda.Delete(id);
        }
    }
}
