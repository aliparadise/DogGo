using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IWalkRepository
    {
        List<Walks> GetAllWalks();
        List<Walks> GetWalksByWalkerId(int walkerId);
    }
}
