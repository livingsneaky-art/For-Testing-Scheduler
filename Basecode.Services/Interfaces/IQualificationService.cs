﻿using Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Services.Interfaces
{
    public interface IQualificationService
    {
        /// <summary>
        /// Gets the qualifications.
        /// </summary>
        /// <returns></returns>
        List<Qualification> GetQualifications();
        /// <summary>
        /// Creates the specified qualification.
        /// </summary>
        /// <param name="qualification">The qualification.</param>
        void Create(Qualification qualification);
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Qualification GetById(int id);

        /// <summary>
        /// Gets the qualifications by job opening identifier.
        /// </summary>
        /// <param name="jobOpeningId">The job opening identifier.</param>
        /// <returns></returns>
        List<Qualification> GetQualificationsByJobOpeningId(int jobOpeningId);
        /// <summary>
        /// Updates the specified qualification.
        /// </summary>
        /// <param name="qualification">The qualification.</param>
        void Update(Qualification qualification);
        /// <summary>
        /// Deletes the specified qualification.
        /// </summary>
        /// <param name="qualification">The qualification.</param>
        void Delete(Qualification qualification);
    }
}