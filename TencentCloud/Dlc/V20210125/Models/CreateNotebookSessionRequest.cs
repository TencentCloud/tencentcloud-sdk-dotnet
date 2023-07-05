/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class CreateNotebookSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// Session名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 类型，当前支持：spark、pyspark、sparkr、sql
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// DLC Spark作业引擎名称
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// session文件地址，当前支持：cosn://和lakefs://两种路径
        /// </summary>
        [JsonProperty("ProgramDependentFiles")]
        public string[] ProgramDependentFiles{ get; set; }

        /// <summary>
        /// 依赖的jar程序地址，当前支持：cosn://和lakefs://两种路径
        /// </summary>
        [JsonProperty("ProgramDependentJars")]
        public string[] ProgramDependentJars{ get; set; }

        /// <summary>
        /// 依赖的python程序地址，当前支持：cosn://和lakefs://两种路径
        /// </summary>
        [JsonProperty("ProgramDependentPython")]
        public string[] ProgramDependentPython{ get; set; }

        /// <summary>
        /// 依赖的pyspark虚拟环境地址，当前支持：cosn://和lakefs://两种路径
        /// </summary>
        [JsonProperty("ProgramArchives")]
        public string[] ProgramArchives{ get; set; }

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
        /// Session相关配置，当前支持：
        /// 1. dlc.eni: 用户配置的eni网关信息，可以通过该字段设置；
        /// 2. dlc.role.arn: 用户配置的roleArn鉴权策略配置信息，可以通过该字段设置；
        /// 3. dlc.sql.set.config: 用户配置的集群配置信息，可以通过该字段设置；
        /// </summary>
        [JsonProperty("Arguments")]
        public KVPair[] Arguments{ get; set; }

        /// <summary>
        /// 代理用户，默认为root
        /// </summary>
        [JsonProperty("ProxyUser")]
        public string ProxyUser{ get; set; }

        /// <summary>
        /// 指定的Session超时时间，单位秒，默认3600秒
        /// </summary>
        [JsonProperty("TimeoutInSecond")]
        public long? TimeoutInSecond{ get; set; }

        /// <summary>
        /// 指定的Executor数量（最大值），默认为1，当开启动态分配有效，若未开启，则该值等于ExecutorNumbers
        /// </summary>
        [JsonProperty("ExecutorMaxNumbers")]
        public ulong? ExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// 指定spark版本名称，当前任务使用该spark镜像运行
        /// </summary>
        [JsonProperty("SparkImage")]
        public string SparkImage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamArraySimple(map, prefix + "ProgramDependentFiles.", this.ProgramDependentFiles);
            this.SetParamArraySimple(map, prefix + "ProgramDependentJars.", this.ProgramDependentJars);
            this.SetParamArraySimple(map, prefix + "ProgramDependentPython.", this.ProgramDependentPython);
            this.SetParamArraySimple(map, prefix + "ProgramArchives.", this.ProgramArchives);
            this.SetParamSimple(map, prefix + "DriverSize", this.DriverSize);
            this.SetParamSimple(map, prefix + "ExecutorSize", this.ExecutorSize);
            this.SetParamSimple(map, prefix + "ExecutorNumbers", this.ExecutorNumbers);
            this.SetParamArrayObj(map, prefix + "Arguments.", this.Arguments);
            this.SetParamSimple(map, prefix + "ProxyUser", this.ProxyUser);
            this.SetParamSimple(map, prefix + "TimeoutInSecond", this.TimeoutInSecond);
            this.SetParamSimple(map, prefix + "ExecutorMaxNumbers", this.ExecutorMaxNumbers);
            this.SetParamSimple(map, prefix + "SparkImage", this.SparkImage);
        }
    }
}

