using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL_Layer_NNINO.Interfaces;
using BL_Layer_NNINO.TransferObjects;
using BL_Layer_NNINO.Infrastructure;
using AutoMapper;
using WEB_NNINO.Models;

namespace WEB_NNINO.Controllers
{
    public class StudentController : ApiController
    {
        IStudentService StudentService;

        public StudentController(IStudentService StudentService)
        {
            if (StudentService == null)
                throw new ArgumentNullException();

            this.StudentService = StudentService;

        }



        public IHttpActionResult Get()
        {
            IEnumerable<StudentDTO> studentDTO = StudentService.GetItems();
            return Ok(Mapper.Map<IEnumerable<StudentDTO>, IEnumerable<StudentViewModel>>(studentDTO));
        }

        // GET: api/Game/5
        public IHttpActionResult Get(int? id)
        {
            if (id == null)            
                return NotFound();
            
            StudentViewModel studentView = Mapper.Map<StudentDTO, StudentViewModel>(StudentService.GetItem(id));

            if (studentView == null)            
                return NotFound(); ;
            
            return Ok(studentView);
        }

        // POST: api/Game
        public IHttpActionResult Post([FromBody]StudentViewModel studentView)
        {
            if (studentView == null)
            {
                return BadRequest();
            }
            var studentDTO = new StudentDTO();
            studentDTO.Id = studentView.Id;
            studentDTO.Name = studentView.Name;
            studentDTO.Surname = studentView.Surname;
            StudentService.CreateItem(studentDTO);
            return Ok();
        }
        // PUT: api/Game/5
        public IHttpActionResult Put(int? id, [FromBody]StudentViewModel studentView)
        {
            if (id == null)
                return BadRequest();
            
            if (studentView == null)
                return BadRequest();
            

            var item = StudentService.GetItem(id);
            item.Id = studentView.Id;
            item.Name = studentView.Name;
            item.Surname = studentView.Surname;
            StudentService.EditItem(item);
            return Ok();

        }

        //// DELETE: api/Game/5
        //public IHttpActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    GameViewModel gameView = Mapper.Map<studentDTO, GameViewModel>(GameService.GetItem(id));

        //    if (gameView == null)
        //    {

        //        _log.Warn(LogMessageComposer.Compose(
        //            new
        //            {
        //                details = "Entity not found in db",
        //                user = "Anonimous",
        //                entity = typeof(studentDTO).Name,
        //                id = id
        //            }));
        //        return NotFound();
        //    }
        //    else
        //    {
        //        GameService.DeleteItem(id);
        //        return Ok();
        //    }
        //}


        //[Route("api/genres/{id:int}/games")]
        //public IHttpActionResult GetgamesPerGenre(int? id)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }

        //    var games = Mapper.Map<IEnumerable<studentDTO>, IEnumerable<GameViewModel>>(GameService.GetGamesperGenre(id.Value));
        //    return Ok(games);

        //}
        //[Route("api/games/{id:int}/download")]
        //public IHttpActionResult GetGame()
        //{
        //    var fileInfo = new FileInfo($"{HttpRuntime.AppDomainAppPath}/File/File.bin");
        //    return !fileInfo.Exists
        //        ? (IHttpActionResult)NotFound()
        //        : new FileResult(fileInfo.FullName);
        //}
        //[Route("api/games/{id:int}/comments")]
        //public IHttpActionResult GetGameComments(int? id)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }
        //    var comments = Mapper.Map<IEnumerable<CommentDTO>, IEnumerable<CommentViewModel>>(GameService.GetCommentforGame(id.Value));
        //    return Ok(comments);
        //}
        //[Route("api/games/{id}/comments")]
        //public IHttpActionResult AddComment(int? id, CommentViewModel comment)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }

        //    if (comment == null)
        //    {
        //        return BadRequest();
        //    }
        //    GameService.AddCommentToGame(id, Mapper.Map<CommentViewModel, CommentDTO>(comment));
        //    return Ok();
        //}
        //[Route("api/comments/{id}/comments")]
        //public IHttpActionResult AddCommentToComment(int? id, CommentViewModel comment)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }

        //    if (comment == null)
        //    {
        //        return BadRequest();
        //    }
        //    GameService.AddCommentToComment(id.Value, Mapper.Map<CommentViewModel, CommentDTO>(comment));
        //    return Ok();
        //}

    }
}
