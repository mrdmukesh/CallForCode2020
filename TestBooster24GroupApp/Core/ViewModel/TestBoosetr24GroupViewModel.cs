using TestBooster24GroupApp.Controllers;
using TestBooster24GroupApp.Core.Helpers;
using TestBooster24GroupApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace TestBooster24GroupApp.Core.ViewModel
{
    public class TestBoosetr24GroupViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int GroupOwnerId { get; set; }
        [Required]
        [ValidDate]
        public DateTime CreationDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public ICollection<Patient> Patients { get; set; }
        [Required]
        public int TestStatus { get; set; }

        public byte City { get; set; }
        public IEnumerable<City> Cities { get; set; }

        public string Action
        {
            get
            {
                Expression<Func<TestBoosetr24GroupController, ActionResult>> edit = (c => c.Edit(this));
                Expression<Func<TestBoosetr24GroupController, ActionResult>> create = (c => c.Create(this));

                var action = (Id != 0) ? edit : create;
                return (action.Body as MethodCallExpression).Method.Name;

            }
        }


    }
}