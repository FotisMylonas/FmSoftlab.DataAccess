﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FMSoftlab.DataAccess
{
    public class SqlExecutionInfo
    {
        public string Sql { get; set; }
        public CommandType CommandType { get; set; }
        public DynamicParameters DynamicParameters { get; set; }
        public SqlExecutionInfo()
        {

        }
    }
}