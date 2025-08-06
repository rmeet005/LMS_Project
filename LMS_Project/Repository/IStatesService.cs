using LMS_Project.DTO;

namespace LMS_Project.Repository
{
    public interface IStatesService
    {
        public void AddState(StatesDto state);
        public List<StatesDto> FetchAllStates();
        public void UpdateState(StatesDto state);
        public void DeleteState(int StateId);
    }
}
