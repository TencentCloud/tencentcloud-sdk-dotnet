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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetInstanceLogRequest : AbstractModel
    {
        
        /// <summary>
        /// **项目ID**
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// **实例唯一标识**
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// **实例生命周期编号，标识实例的某一次执行**
        /// 
        /// 例如：周期实例第一次运行的编号为0，用户后期又重跑了该实例，第二次执行的编号为1
        /// </summary>
        [JsonProperty("LifeRoundNum")]
        public ulong? LifeRoundNum{ get; set; }

        /// <summary>
        /// **时区**
        /// timeZone, 默认UTC+8
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// **日志所在执行机Ip**
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// **日志文件**
        /// 实例详情中 executionJobId 为空时，但 originFileName 不为空时，入参中必须包含 originFileName 与 brokerIp
        /// 如果 executionJobId 与 originFileName 都为空，则说明实例未下发执行或没有产生日志。例如分支节点 或 归并节点
        /// </summary>
        [JsonProperty("OriginFileName")]
        public string OriginFileName{ get; set; }

        /// <summary>
        /// **执行ID**
        /// 
        /// 实例详情中 executionJobId 不为空时，入参中需包含executionJobId 。originFileName 与 brokerIp为非必要参数
        /// </summary>
        [JsonProperty("ExecutionJobId")]
        public string ExecutionJobId{ get; set; }

        /// <summary>
        /// **日志级别**
        /// 默认All
        /// 
        /// - Info
        /// - Debug
        /// - Warn
        /// - Error
        /// - All
        /// </summary>
        [JsonProperty("LogLevel")]
        public string LogLevel{ get; set; }

        /// <summary>
        /// **获取日志的开始行 行号**
        /// 默认 1
        /// </summary>
        [JsonProperty("StartLineNum")]
        public ulong? StartLineNum{ get; set; }

        /// <summary>
        /// **获取日志的结束行 行号**
        /// 默认 10000
        /// </summary>
        [JsonProperty("EndLineCount")]
        public ulong? EndLineCount{ get; set; }

        /// <summary>
        /// **分页查询日志时使用，无具体业务含义**
        /// 
        /// 第一次查询时值为null 
        /// 第二次及以后查询时使用上一次查询返回信息中的ExtInfo字段值即可
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "LifeRoundNum", this.LifeRoundNum);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "OriginFileName", this.OriginFileName);
            this.SetParamSimple(map, prefix + "ExecutionJobId", this.ExecutionJobId);
            this.SetParamSimple(map, prefix + "LogLevel", this.LogLevel);
            this.SetParamSimple(map, prefix + "StartLineNum", this.StartLineNum);
            this.SetParamSimple(map, prefix + "EndLineCount", this.EndLineCount);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

