﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Platformus.Barebone;
using Platformus.Barebone.Backend.ViewModels;
using Platformus.Security.Data.Models;

namespace Platformus.Security.Backend.ViewModels.Shared
{
  public class RoleViewModelBuilder : ViewModelBuilderBase
  {
    public RoleViewModelBuilder(IHandler handler)
      : base(handler)
    {
    }

    public RoleViewModel Build(Role role)
    {
      return new RoleViewModel()
      {
        Id = role.Id,
        Name = role.Name,
        Position = role.Position
      };
    }
  }
}