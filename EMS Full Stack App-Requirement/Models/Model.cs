using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DAL_EMS;
using BLL_EMS;

namespace EMS_Full_Stack_App_Requirement.Models
{
    public class DeptModel
    {
       
        public int DeptCode { get; set; }
        public string DeptName { get; set; }

        
    }
    public class EmpModel
    {
     
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public DateTime DateOfBirth { get; set; }    
        public string Email { get; set; }
        public int DeptCode { get; set; }

       

    }
}