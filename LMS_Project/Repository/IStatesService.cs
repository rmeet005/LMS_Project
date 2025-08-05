using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IStatesService
    {
        public void AddState(StatesDto state);
        public List<StatesDto> FetchAllStates();
    }
}
