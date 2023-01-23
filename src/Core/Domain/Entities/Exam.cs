﻿using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Exam
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public string Type { get; set; } = null!;

    public DateTime Date { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string Location { get; set; } = null!;

    public virtual Course? Course { get; set; }

    public virtual ICollection<ExamScore> ExamScores { get; } = new List<ExamScore>();
}
