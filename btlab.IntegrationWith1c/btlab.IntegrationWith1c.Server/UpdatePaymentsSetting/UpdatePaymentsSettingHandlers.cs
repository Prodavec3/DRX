﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using btlab.IntegrationWith1c.UpdatePaymentsSetting;

namespace btlab.IntegrationWith1c
{
  partial class UpdatePaymentsSettingServerHandlers
  {

    public override void Created(Sungero.Domain.CreatedEventArgs e)
    {
      _obj.Actual = false;
    }
  }

}