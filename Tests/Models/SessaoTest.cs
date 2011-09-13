using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using AgileTickets.Web.Models;

namespace Tests.Models
{
    [TestFixture]
    public class SessaoTest
    {
        Sessao s;
        [SetUp]
        public void Inicializa()
        { 
            s = new Sessao();
        }

        [Test]
        public void DeveVender1IngressoSeHa2Vagas()
        {
            s.TotalDeIngressos = 2;
            Assert.IsTrue(s.PodeReservar(1));
        }
        [Test]
        public void NaodeveVender3IngressoSeHa2Vagas()
        {
            s.TotalDeIngressos = 2;
            Assert.IsFalse(s.PodeReservar(3));
        }
        [Test]
        public void ReservarIngressosDeveDiminuirONumeroDeIngressosDisponiveis()
        {
            s.TotalDeIngressos = 5;
            s.Reserva(3);
            Assert.AreEqual(2, s.IngressosDisponiveis);
        }
    }
}
