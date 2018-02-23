using ElasticSearchDbAndNest.Models;
using ElasticSearchDbAndNest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ElasticSearchDbAndNest.Controllers
{
    public class CompanyController : ApiController
    {
        private RepositoryBase<Company, string> _companyRepo;
        private RepositoryBase<Log, string> _logRepo;
        public CompanyController()
        {
            _companyRepo = new RepositoryBase<Company,string>();
            _logRepo = new RepositoryBase<Log, string>();

        }
        /// <summary>
        /// Inserts the company record on ElasticDB
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Create")]
        [ResponseType((typeof(Company)))]
        public IHttpActionResult CreateCompany(Company company)
        {
            var result = _companyRepo.Insert(company);

            Log log = new Log() { LogType = "Info", Description = $"Created company in DB, company name : {company.CompanyName}" };
            _logRepo.Insert(log);
            return Ok(result);
        }


        [HttpGet]
        [Route("GetAll")]
        [ResponseType((typeof(Company)))]
        public IHttpActionResult GetAllCompanies()
        {
            var result = _companyRepo.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllRaw")]
        [ResponseType((typeof(Company)))]
        public IHttpActionResult GetAllCompaniesRaw()
        {
            var result = _companyRepo.GetAllRaw();
            return Ok(result);
        }
    }
}
