﻿using Microsoft.AspNetCore.Identity;
using SMCS.BusinessLogic.Interfaces;
using SMCS.Data.DataAccess.Interfaces;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.BusinessLogic.Services
{
    public class ServicesManager : IServicesManager
    {
        public ServicesManager(IUnitOfWork unitOfWork)
        {
            //UsersManager = new 
            TicketsService = new TicketService(unitOfWork);
        }

        public IArticlesService ArticlesService { get; private set; }

        public ITicketsService TicketsService { get; private set; }

        public IChatService ChatService { get; private set; }
    }
}
