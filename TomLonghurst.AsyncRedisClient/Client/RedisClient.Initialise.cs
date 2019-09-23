using System.Threading.Tasks;

namespace TomLonghurst.AsyncRedisClient.Client
{
    public partial class RedisClient
    {
        //private DedicatedScheduler _backlogScheduler = new DedicatedScheduler(workerCount: 1);

        protected RedisClient()
        {
            CreateCommandClasses();

            StartBacklogProcessor();
        }

        private void CreateCommandClasses()
        {
            _clusterCommands = new ClusterCommands(this);
            _serverCommands = new ServerCommands(this);
            _scriptCommands = new ScriptCommands(this);
        }
    }
}