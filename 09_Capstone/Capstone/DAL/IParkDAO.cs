﻿using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAL
{
    public interface IParkDAO
    {
        IList<Park> GetAllParks();
        Park GetPark(int parkId);
    }
}