using Microsoft.AspNetCore.Mvc;
using LaboratorioAws.DTO;
using Model.Entities;
using Model.Interfaces;            // -> Nuevo namespace
//using LaboratorioAws.Entities;        // -> Antiguo namespace


namespace LaboratorioAws.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;           // Now imported from the Repository project

        //public PlayersController(DataContext context)
        //{
        //    _dbContext = context;
        //}

        public PlayersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            var players = await _unitOfWork.Players.GetAll();
            return Ok(players);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = await _unitOfWork.Players.GetId(id);
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }

        [HttpGet("number/{number}")]
        public async Task<ActionResult<Player>> GetPlayerByNumber(int number)
        {
            var player = await _unitOfWork.Players.GetPlayerByNumber(number);
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }

        [HttpPost]
        public async Task<ActionResult> AddPlayer(PlayerDto playerDto)
        {
            if (playerDto == null)
            {
                return BadRequest();
            }

            var dateStringArray = playerDto.DateOfBirthYyyyMmDd.Split("-");
            var dateArray = dateStringArray.Select(n => int.Parse(n)).ToArray();

            var player = new Player
            {
                Name = playerDto.Name,
                Surname = playerDto.Surname,
                Position = playerDto.Position,
                Number = playerDto.Number,
                DocumentType = playerDto.DocumentType,
                DocumentNumber = playerDto.DocumentNumber,
                Starter = playerDto.Starter,
                DateOfBirth = new DateTime(dateArray[0], dateArray[1], dateArray[2])
            };

            await _unitOfWork.Players.Add(player);
            //await _unitOfWork.SaveAsync();                // Deprecated: now Add() is async

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, PlayerDto playerDto)
        {
            var existingPlayer = await _unitOfWork.Players.GetId(id);       // Method from Repository 
            if (existingPlayer == null)
            {
                return NotFound();
            }

            var dateStringArray = playerDto.DateOfBirthYyyyMmDd.Split("-");
            var dateArray = dateStringArray.Select(n => int.Parse(n)).ToArray();

            existingPlayer.Name = playerDto.Name;
            existingPlayer.Surname = playerDto.Surname;
            existingPlayer.Position = playerDto.Position;
            existingPlayer.Number = playerDto.Number;
            existingPlayer.DocumentType = playerDto.DocumentType;
            existingPlayer.DocumentNumber = playerDto.DocumentNumber;
            existingPlayer.Starter = playerDto.Starter;
            existingPlayer.DateOfBirth = new DateTime(dateArray[0], dateArray[1], dateArray[2]);

            _unitOfWork.Players.Edit(existingPlayer);     // Name change: Update -> Edit
            await _unitOfWork.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingPlayer = await _unitOfWork.Players.GetId(id);
            if (existingPlayer == null)
            {
                return NotFound();
            }

            _unitOfWork.Players.Delete(existingPlayer);     // Name change: Remove -> Delete
            await _unitOfWork.SaveAsync();                  // Name change: SaveChangesAsync -> SaveAsync

            return NoContent();
        }
    }
}