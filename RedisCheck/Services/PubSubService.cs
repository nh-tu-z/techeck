using StackExchange.Redis;
using Newtonsoft.Json;

namespace RedisCheck.Services
{
    /// <summary>
    /// Class object used to modify Redis PubSub feature
    /// </summary>
    public class PubSubService
    {
        private readonly string _channel = "redis-test-channel";
        private IConnectionMultiplexer _redis;

        public PubSubService()
        {
            _redis = ConnectionMultiplexer.Connect("localhost");
        }


        /// <summary>
        /// General example
        /// </summary>
        public void ExecuteExample1()
        {
            // Pub
            var subscriber = _redis.GetSubscriber();
            subscriber.Subscribe(_channel, (channel, message) =>
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}]: {$"{message} received successfully"}");
            });

            // Sub
            for (var i = 0; i < 10; ++i)
            {
                subscriber.Publish(_channel, $"Message {i}");
                Console.WriteLine($"Message {i} published successfully");
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Problem 1: the second pub message has to wait until first pub message handled successfully to be handled
        /// Note: look like it's not a problem, double check the latency in https://redis.io/docs/management/optimization/latency/
        /// </summary>
        public void ExecuteProblem1()
        {
            /* Simulate problem 1: T.B.D */
            var listJobs = new List<JobSimulator>() 
            {
                new JobSimulator() { JobName = "JobA", TimeToComplete = 4000 },
                new JobSimulator() { JobName = "JobB", TimeToComplete = 6000 },
                new JobSimulator() { JobName = "JobC", TimeToComplete = 8000 }
            };

            var subscriber = _redis.GetSubscriber();
            subscriber.Subscribe(_channel, (channel, message) =>
            {
                var job = JsonConvert.DeserializeObject<JobSimulator>(message);
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}]: {$"Handle {job.JobName}..."}");
                Thread.Sleep(job.TimeToComplete);
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}]: {$"Handle {job.JobName} successfully"}");
            });

            foreach (var job in listJobs)
            {
                subscriber.Publish(_channel, JsonConvert.SerializeObject(job));
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}]: Message for {job.JobName} published successfully");
            }
        }
    }

    // TODO - add color for each job to visualize
    public class JobSimulator
    {
        public int TimeToComplete { get; set; }
        public string JobName { get; set; } = string.Empty;
    }
}
