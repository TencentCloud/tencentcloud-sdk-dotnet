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

    public class DescribeInstanceLogDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>任务id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>数据时间</p>
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// <p>日志级别，Info/Debug/Warn/Error/All</p>
        /// </summary>
        [JsonProperty("LogLevelType")]
        public string LogLevelType{ get; set; }

        /// <summary>
        /// <p>文件类型,Log/Code</p>
        /// </summary>
        [JsonProperty("ExecutionFileType")]
        public string ExecutionFileType{ get; set; }

        /// <summary>
        /// <p>统一执行平台执行id, 注意: ExecutionJobId 跟 &quot;BrokerIp+OriginFileName&quot; 必须有一个不为空</p>
        /// </summary>
        [JsonProperty("ExecutionJobId")]
        public string ExecutionJobId{ get; set; }

        /// <summary>
        /// <p>服务器Ip, 注意: &quot;BrokerIp+OriginFileName&quot;跟ExecutionJobId必须有一个不为空</p>
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// <p>文件Name, 注意: &quot;BrokerIp+OriginFileName&quot;跟ExecutionJobId必须有一个不为空</p>
        /// </summary>
        [JsonProperty("OriginFileName")]
        public string OriginFileName{ get; set; }

        /// <summary>
        /// <p>起始行</p>
        /// </summary>
        [JsonProperty("StartCount")]
        public long? StartCount{ get; set; }

        /// <summary>
        /// <p>每次查询行数</p>
        /// </summary>
        [JsonProperty("LineCount")]
        public long? LineCount{ get; set; }

        /// <summary>
        /// <p>查询日志扩展信息,通过统一执行平台接口分页查询日志时需要带上,第一页时为null</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// 请求来源，WEB 前端；CLIENT 客户端
        /// </summary>
        [JsonProperty("RequestFromSource")]
        public string RequestFromSource{ get; set; }

        /// <summary>
        /// <p>生命周期为基础数据进行日志匹配</p>
        /// </summary>
        [JsonProperty("InstanceLifeDetailDtoList")]
        public InstanceLifeDetailDto[] InstanceLifeDetailDtoList{ get; set; }

        /// <summary>
        /// <p>当前生命周期</p>
        /// </summary>
        [JsonProperty("CurrentLifeRound")]
        public long? CurrentLifeRound{ get; set; }

        /// <summary>
        /// <p>生命周期总数</p>
        /// </summary>
        [JsonProperty("MaxLifeRound")]
        public long? MaxLifeRound{ get; set; }

        /// <summary>
        /// <p>当前生命周期重试次数</p>
        /// </summary>
        [JsonProperty("Tries")]
        public long? Tries{ get; set; }

        /// <summary>
        /// <p>动态加载日志</p>
        /// </summary>
        [JsonProperty("Dynamic")]
        public bool? Dynamic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "LogLevelType", this.LogLevelType);
            this.SetParamSimple(map, prefix + "ExecutionFileType", this.ExecutionFileType);
            this.SetParamSimple(map, prefix + "ExecutionJobId", this.ExecutionJobId);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "OriginFileName", this.OriginFileName);
            this.SetParamSimple(map, prefix + "StartCount", this.StartCount);
            this.SetParamSimple(map, prefix + "LineCount", this.LineCount);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "RequestFromSource", this.RequestFromSource);
            this.SetParamArrayObj(map, prefix + "InstanceLifeDetailDtoList.", this.InstanceLifeDetailDtoList);
            this.SetParamSimple(map, prefix + "CurrentLifeRound", this.CurrentLifeRound);
            this.SetParamSimple(map, prefix + "MaxLifeRound", this.MaxLifeRound);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamSimple(map, prefix + "Dynamic", this.Dynamic);
        }
    }
}

