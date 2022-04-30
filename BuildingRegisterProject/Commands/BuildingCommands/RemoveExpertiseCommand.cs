﻿using BuildingRegisterProject.Commands.Contracts;
using BuildingRegisterProject.Model.Entities;
using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace BuildingRegisterProject.Commands.BuildingCommands
{
    public class RemoveExpertiseCommand : Notifiable, ICommand
    {
        public RemoveExpertiseCommand(Guid id, Expertise expertise)
        {
            Id = id;
            Expertise = expertise;
        }

        public Guid Id { get; set; }
        public Expertise Expertise { get; set; }

        public void Validate()
        {
            AddNotifications(
               new Contract()
                   .Requires()
                   .IsNotNullOrEmpty(Expertise.Name, "Expertise", "The expertise field cannot be null")
               );
        }
    }
}