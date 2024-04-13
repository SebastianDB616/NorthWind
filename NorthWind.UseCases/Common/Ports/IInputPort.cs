﻿using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.UseCases.Common.Ports
{
    public interface IInputPort<InteractorRequestType, InteractorResponseType> : IRequest
    {
        public InteractorRequestType RequestData { get; }
        public IOutputPort<InteractorResponseType> OutputPort { get; }
    }
}
