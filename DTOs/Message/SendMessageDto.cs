﻿namespace TourManagementSystem.DTOs.Message
{
    public class SendMessageDto
    {
        public int Id { get; set; }

        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public int SenderId { get; set; }


        public int ReceiverId { get; set; }
    }
}
