using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ChakGenericCore.Infrastructure
{
    public class RequestPerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly Stopwatch _timer;
        private readonly ILogger<TRequest> _logger;
        private readonly string _projectName;

        public RequestPerformanceBehaviour(ILogger<TRequest> logger, string projectName)
        {
            _timer = new Stopwatch();

            _logger = logger;

            _projectName = projectName;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            _timer.Start();

            var response = await next();

            _timer.Stop();

            if (_timer.ElapsedMilliseconds > 500)
            {
                var name = typeof(TRequest).Name;

                // TODO: Add User Details

                _logger.LogWarning($"{_projectName} Long Running Request: {name} ({_timer.ElapsedMilliseconds} milliseconds) {request}");
            }

            return response;
        }
    }
}
