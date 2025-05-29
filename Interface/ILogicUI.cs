// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using PIS_InfoSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIS_InfoSystem.Model;

namespace PIS_InfoSystem.Interface
{
    public interface ILogicUI
    {
        User? Login(string login, string password);
    }
}
