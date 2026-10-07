using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// GolBet.Services/Interfaces/ITeamService.cs 

using GolBet.Services.DTOs;



namespace GolBet.Services.Interfaces;



public interface ITeamService

{

    Task<IEnumerable<TeamDto>> GetAllAsync();

    Task<TeamFormDto?> GetForEditAsync(int id);

    Task CreateAsync(TeamFormDto dto);

    Task UpdateAsync(TeamFormDto dto);

    Task DeactivateAsync(int id);

}