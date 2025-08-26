/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Process : AbstractModel
    {
        
        /// <summary>
        /// 线程ID​​：唯一标识当前连接/线程的整数。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 用户名​​：发起连接的 MySQL 用户。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 客户端地址​​：发起连接的客户端主机名及端口（格式：host:port）。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 当前数据库​​：线程正在使用的数据库名（未选择数据库时为 空串）。
        /// </summary>
        [JsonProperty("Db")]
        public string Db{ get; set; }

        /// <summary>
        /// 命令类型​​：线程正在执行的命令类型。常见值：
        /// 
        /// - Sleep：空闲等待状态（等待新查询）。
        /// - Query：正在执行查询或 SQL 语句。
        /// - Binlog Dump：主服务器线程向从服务器发送二进制日志。
        /// - Connect：客户端正在连接。
        /// - Killed：线程被终止但未完全退出。
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 执行时间（秒）​​：线程在当前状态持续的秒数。
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// 执行开始时间（秒）​​：线程在当前状态开始执行的时间。
        /// </summary>
        [JsonProperty("ProcessStartTime")]
        public string ProcessStartTime{ get; set; }

        /// <summary>
        /// ​​状态描述​​：线程当前的详细操作状态。常见值：
        /// 
        /// - Sending data：正在处理/发送数据。
        /// - Locked：等待表锁释放（例如 MyISAM 表级锁）。
        /// - Sorting result：排序查询结果。
        /// - Updating：更新表中数据。
        /// - 当为NULL返回空串：无明确状态（如 Sleep 时）。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 执行语句​​：正在执行的 SQL 语句（前 1024 字符）。
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Db", this.Db);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "ProcessStartTime", this.ProcessStartTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Info", this.Info);
        }
    }
}

