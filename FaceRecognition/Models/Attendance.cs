﻿using System;
using System.Collections.Generic;

namespace FaceRecognition.Models;

public partial class Attendance
{
    public int Id { get; set; }

    public DateOnly? AttendanceDate { get; set; }

    public string? Note { get; set; }
}
