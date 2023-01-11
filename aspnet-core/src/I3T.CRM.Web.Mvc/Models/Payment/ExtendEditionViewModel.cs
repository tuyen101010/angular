﻿using System.Collections.Generic;
using I3T.CRM.Editions.Dto;
using I3T.CRM.MultiTenancy.Payments;

namespace I3T.CRM.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}