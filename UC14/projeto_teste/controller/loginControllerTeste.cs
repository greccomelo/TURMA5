using Chapter.Controllers;
using Chapter.Interfaces;
using Chapter.Models;
using Chapter.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace projeto_teste.controller
{
    public class loginControllerTeste
    {
        [Fact]
        public void LoginController_Retornar_Usuario_Invalido()
        {
            //arrange
            var fakeRepository = new Mock<IUsuarioRepository>();
            fakeRepository.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns((Usuario)null);

            LoginViewModel dadosLogin = new LoginViewModel();
            dadosLogin.Email = "email@email.com";
            dadosLogin.Senha = "1234";

            var controller = new LoginController(fakeRepository.Object);

            //act
            var resultado = controller.Login(dadosLogin);

            //assert
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }
    }
}
