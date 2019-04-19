﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Middleware;

using SharedPluginFeatures;

namespace HelpdeskPlugin.Models
{
    public sealed class SubmitTicketViewModel : BaseModel
    {
        #region Constructors

        public SubmitTicketViewModel()
        {

        }

        public SubmitTicketViewModel(in List<BreadcrumbItem> breadcrumbs, in ShoppingCartSummary cartSummary,
            in List<LookupListItem> departments, in List<LookupListItem> priorities, 
            in string username, in string email, in string subject, in string message)
            : base (breadcrumbs, cartSummary)
        {
            Departments = departments ?? throw new ArgumentNullException(nameof(departments));
            Priorities = priorities ?? throw new ArgumentNullException(nameof(priorities));
            Username = username;
            Email = email;
            Subject = subject ?? String.Empty;
            Message = message ?? String.Empty;
        }

        #endregion Constructors

        #region Properties

        public List<LookupListItem> Departments { get; private set; }

        public List<LookupListItem> Priorities { get; private set; }

        public string Department { get; set; }

        public string Priority { get; set; }

        [Required(ErrorMessage = nameof(Languages.LanguageStrings.PleaseEnterFirstLastName))]
        public string Username { get; set; }

        [Required(ErrorMessage = nameof(Languages.LanguageStrings.InvalidEmailAddress))]
        public string Email { get; set; }

        [Required(ErrorMessage = nameof(Languages.LanguageStrings.Subject))]
        public string Subject { get; set; }

        [Required(ErrorMessage = nameof(Languages.LanguageStrings.SupportTicketMessageRequired))]
        public string Message { get; set; }

        [Required(ErrorMessage = nameof(Languages.LanguageStrings.CodePleaseEnter))]
        public string CaptchaText { get; set; }

        #endregion Properties
    }
}
