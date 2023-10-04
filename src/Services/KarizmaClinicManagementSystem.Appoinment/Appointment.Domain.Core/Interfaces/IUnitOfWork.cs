﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.Domain.Core.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task<int> CommitAsync(
           CancellationToken cancellationToken = default);
}