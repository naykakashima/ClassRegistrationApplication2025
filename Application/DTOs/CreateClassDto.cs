﻿#nullable disable

using ClassRegistrationApplication2025.Domain.Entities;

namespace ClassRegistrationApplication2025.Application.DTOs

{
        public class CreateClassDto
        {
            public string ClassName { get; set; }
            public string PresenterName { get; set; }
            public string SessionName { get; set; }
            public DateTime? Date { get; set; }
            public TimeSpan? StartTime { get; set; }
            public TimeSpan? EndTime { get; set; }
            public int MaxSlots { get; set; }
            public Guid CreatedByUserId { get; set; }
            public User CreatedByUser { get; set; }
    }

}
