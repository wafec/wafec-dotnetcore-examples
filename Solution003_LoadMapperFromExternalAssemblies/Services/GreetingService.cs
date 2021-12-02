using AutoMapper;
using System;

namespace Services
{
    public class GreetingService
    {
        private IMapper _mapper;
        private GreetingBuilder _greetingBuilder;

        public GreetingService(GreetingBuilder greetingBuilder, IMapper mapper) =>
            (_greetingBuilder, _mapper) = (greetingBuilder, mapper);

        public GreetingModel SayHello(HelloMessage message)
        {
            return _mapper.Map<GreetingModel>(_greetingBuilder.ProcessGreeting(_mapper.Map<GreetingRequest>(message)));
        }
    }
}
