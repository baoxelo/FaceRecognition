﻿using System;
using System.Collections.Generic;

namespace FaceRecognition.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? StudentId { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public DateOnly? Birthdate { get; set; }
}
