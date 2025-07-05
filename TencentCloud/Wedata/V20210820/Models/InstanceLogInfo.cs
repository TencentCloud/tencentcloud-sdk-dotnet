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

    public class InstanceLogInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 数据时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// 尝试运行次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tries")]
        public string Tries{ get; set; }

        /// <summary>
        /// 日志更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdate")]
        public string LastUpdate{ get; set; }

        /// <summary>
        /// 日志所在节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// 文件大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileSize")]
        public string FileSize{ get; set; }

        /// <summary>
        /// 文件名 含全路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginFileName")]
        public string OriginFileName{ get; set; }

        /// <summary>
        /// 日志创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例日志类型, run: 运行; kill: 终止
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceLogType")]
        public string InstanceLogType{ get; set; }

        /// <summary>
        /// 任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 运行耗时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CostTime")]
        public string CostTime{ get; set; }

        /// <summary>
        /// 实例状态 COMPLETED 完成 FAILED失败重试 EXPIRED失败 RUNNING运行中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// 实例代码文件，为空表示对应代码文件不存在，可能是因为执行机未升级/对应类型任务无代码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeFileName")]
        public string CodeFileName{ get; set; }

        /// <summary>
        /// 扩展属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtensionInfo")]
        public AttributeItemDTO[] ExtensionInfo{ get; set; }

        /// <summary>
        /// 统一执行平台，下发执行Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionJobId")]
        public string ExecutionJobId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamSimple(map, prefix + "LastUpdate", this.LastUpdate);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "OriginFileName", this.OriginFileName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "InstanceLogType", this.InstanceLogType);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "CodeFileName", this.CodeFileName);
            this.SetParamArrayObj(map, prefix + "ExtensionInfo.", this.ExtensionInfo);
            this.SetParamSimple(map, prefix + "ExecutionJobId", this.ExecutionJobId);
        }
    }
}

