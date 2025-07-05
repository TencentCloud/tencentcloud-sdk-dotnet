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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSparkSessionBatchSQLRequest : AbstractModel
    {
        
        /// <summary>
        /// DLC Spark作业引擎名称
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// 运行sql，需要base64编码。
        /// </summary>
        [JsonProperty("ExecuteSQL")]
        public string ExecuteSQL{ get; set; }

        /// <summary>
        /// 指定的Driver规格，当前支持：small（默认，1cu）、medium（2cu）、large（4cu）、xlarge（8cu）
        /// </summary>
        [JsonProperty("DriverSize")]
        public string DriverSize{ get; set; }

        /// <summary>
        /// 指定的Executor规格，当前支持：small（默认，1cu）、medium（2cu）、large（4cu）、xlarge（8cu）
        /// </summary>
        [JsonProperty("ExecutorSize")]
        public string ExecutorSize{ get; set; }

        /// <summary>
        /// 指定的Executor数量，默认为1
        /// </summary>
        [JsonProperty("ExecutorNumbers")]
        public ulong? ExecutorNumbers{ get; set; }

        /// <summary>
        /// 指定的Executor数量（最大值），默认为1，当开启动态分配有效，若未开启，则该值等于ExecutorNumbers
        /// </summary>
        [JsonProperty("ExecutorMaxNumbers")]
        public ulong? ExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// 指定的Session超时时间，单位秒，默认3600秒
        /// </summary>
        [JsonProperty("TimeoutInSecond")]
        public long? TimeoutInSecond{ get; set; }

        /// <summary>
        /// Session唯一标识，当指定sessionid，则使用该session运行任务。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 指定要创建的session名称
        /// </summary>
        [JsonProperty("SessionName")]
        public string SessionName{ get; set; }

        /// <summary>
        /// Session相关配置，当前支持：1.dlc.eni：用户配置的eni网关信息，可以用过该字段设置；
        /// 2.dlc.role.arn：用户配置的roleArn鉴权策略配置信息，可以用过该字段设置；
        /// 3.dlc.sql.set.config：用户配置的集群配置信息，可以用过该字段设置；
        /// </summary>
        [JsonProperty("Arguments")]
        public KVPair[] Arguments{ get; set; }

        /// <summary>
        /// 是否继承集群的资源类配置：0：不继承（默认），1：继承集群；
        /// </summary>
        [JsonProperty("IsInherit")]
        public long? IsInherit{ get; set; }

        /// <summary>
        /// 用户自定义主键，需唯一
        /// </summary>
        [JsonProperty("CustomKey")]
        public string CustomKey{ get; set; }

        /// <summary>
        /// 任务来源信息
        /// </summary>
        [JsonProperty("SourceInfo")]
        public KVPair[] SourceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "ExecuteSQL", this.ExecuteSQL);
            this.SetParamSimple(map, prefix + "DriverSize", this.DriverSize);
            this.SetParamSimple(map, prefix + "ExecutorSize", this.ExecutorSize);
            this.SetParamSimple(map, prefix + "ExecutorNumbers", this.ExecutorNumbers);
            this.SetParamSimple(map, prefix + "ExecutorMaxNumbers", this.ExecutorMaxNumbers);
            this.SetParamSimple(map, prefix + "TimeoutInSecond", this.TimeoutInSecond);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionName", this.SessionName);
            this.SetParamArrayObj(map, prefix + "Arguments.", this.Arguments);
            this.SetParamSimple(map, prefix + "IsInherit", this.IsInherit);
            this.SetParamSimple(map, prefix + "CustomKey", this.CustomKey);
            this.SetParamArrayObj(map, prefix + "SourceInfo.", this.SourceInfo);
        }
    }
}

