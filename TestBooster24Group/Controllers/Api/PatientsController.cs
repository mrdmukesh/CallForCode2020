﻿using AutoMapper;
using TestBooster24GroupApp.Core;
using TestBooster24GroupApp.Core.Dto;
using TestBooster24GroupApp.Core.Models;
using System.Linq;
using System.Web.Http;

namespace TestBooster24GroupApp.Controllers.Api
{
    public class PatientsController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public PatientsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public IHttpActionResult GetPatients()
        {
            var patientsQuery = _unitOfWork.Patients.GetPatients();


            var patientDto = patientsQuery.ToList()
                                          .Select(Mapper.Map<Patient, PatientDto>);

            return Ok(patientDto);

        }


        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var patient = _unitOfWork.Patients.GetPatient(id);
            _unitOfWork.Patients.Remove(patient);
            _unitOfWork.Complete();
            return Ok();
        }

    }
}
