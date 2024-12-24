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

    public class NotebookSessionInfo : AbstractModel
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
        /// Session相关配置，当前支持：eni、roleArn以及用户指定的配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Arguments")]
        public KVPair[] Arguments{ get; set; }

        /// <summary>
        /// 运行程序地址，当前支持：cosn://和lakefs://两种路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProgramDependentFiles")]
        public string[] ProgramDependentFiles{ get; set; }

        /// <summary>
        /// 依赖的jar程序地址，当前支持：cosn://和lakefs://两种路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProgramDependentJars")]
        public string[] ProgramDependentJars{ get; set; }

        /// <summary>
        /// 依赖的python程序地址，当前支持：cosn://和lakefs://两种路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProgramDependentPython")]
        public string[] ProgramDependentPython{ get; set; }

        /// <summary>
        /// 依赖的pyspark虚拟环境地址，当前支持：cosn://和lakefs://两种路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProgramArchives")]
        public string[] ProgramArchives{ get; set; }

        /// <summary>
        /// 指定的Driver规格，当前支持：small（默认，1cu）、medium（2cu）、large（4cu）、xlarge（8cu）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DriverSize")]
        public string DriverSize{ get; set; }

        /// <summary>
        /// 指定的Executor规格，当前支持：small（默认，1cu）、medium（2cu）、large（4cu）、xlarge（8cu）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorSize")]
        public string ExecutorSize{ get; set; }

        /// <summary>
        /// 指定的Executor数量，默认为1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorNumbers")]
        public ulong? ExecutorNumbers{ get; set; }

        /// <summary>
        /// 代理用户，默认为root
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyUser")]
        public string ProxyUser{ get; set; }

        /// <summary>
        /// 指定的Session超时时间，单位秒，默认3600秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeoutInSecond")]
        public long? TimeoutInSecond{ get; set; }

        /// <summary>
        /// Spark任务返回的AppId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkAppId")]
        public string SparkAppId{ get; set; }

        /// <summary>
        /// Session唯一标识
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Session状态，包含：not_started（未启动）、starting（已启动）、idle（等待输入）、busy(正在运行statement)、shutting_down（停止）、error（异常）、dead（已退出）、killed（被杀死）、success（正常停止）
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Session创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 其它信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppInfo")]
        public KVPair[] AppInfo{ get; set; }

        /// <summary>
        /// Spark ui地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkUiUrl")]
        public string SparkUiUrl{ get; set; }

        /// <summary>
        /// 指定的Executor数量（最大值），默认为1，当开启动态分配有效，若未开启，则该值等于ExecutorNumbers
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorMaxNumbers")]
        public ulong? ExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// session类型，group：资源组下session independent：独立资源session， 不依赖资源组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionType")]
        public string SessionType{ get; set; }

        /// <summary>
        /// 引擎id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataEngineId")]
        public string DataEngineId{ get; set; }

        /// <summary>
        /// 资源组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 资源组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// session，pod大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodSize")]
        public long? PodSize{ get; set; }

        /// <summary>
        /// pod数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodNumbers")]
        public long? PodNumbers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamArrayObj(map, prefix + "Arguments.", this.Arguments);
            this.SetParamArraySimple(map, prefix + "ProgramDependentFiles.", this.ProgramDependentFiles);
            this.SetParamArraySimple(map, prefix + "ProgramDependentJars.", this.ProgramDependentJars);
            this.SetParamArraySimple(map, prefix + "ProgramDependentPython.", this.ProgramDependentPython);
            this.SetParamArraySimple(map, prefix + "ProgramArchives.", this.ProgramArchives);
            this.SetParamSimple(map, prefix + "DriverSize", this.DriverSize);
            this.SetParamSimple(map, prefix + "ExecutorSize", this.ExecutorSize);
            this.SetParamSimple(map, prefix + "ExecutorNumbers", this.ExecutorNumbers);
            this.SetParamSimple(map, prefix + "ProxyUser", this.ProxyUser);
            this.SetParamSimple(map, prefix + "TimeoutInSecond", this.TimeoutInSecond);
            this.SetParamSimple(map, prefix + "SparkAppId", this.SparkAppId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "AppInfo.", this.AppInfo);
            this.SetParamSimple(map, prefix + "SparkUiUrl", this.SparkUiUrl);
            this.SetParamSimple(map, prefix + "ExecutorMaxNumbers", this.ExecutorMaxNumbers);
            this.SetParamSimple(map, prefix + "SessionType", this.SessionType);
            this.SetParamSimple(map, prefix + "DataEngineId", this.DataEngineId);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamSimple(map, prefix + "PodSize", this.PodSize);
            this.SetParamSimple(map, prefix + "PodNumbers", this.PodNumbers);
        }
    }
}

