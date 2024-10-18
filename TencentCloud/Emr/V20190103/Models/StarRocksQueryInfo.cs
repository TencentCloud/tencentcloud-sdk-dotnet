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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StarRocksQueryInfo : AbstractModel
    {
        
        /// <summary>
        /// 提交IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientIP")]
        public string ClientIP{ get; set; }

        /// <summary>
        /// CPU总时间(ns)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CPUCost")]
        public long? CPUCost{ get; set; }

        /// <summary>
        /// 默认DB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultDB")]
        public string DefaultDB{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 执行IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionIP")]
        public string ExecutionIP{ get; set; }

        /// <summary>
        /// 查询ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryID")]
        public string QueryID{ get; set; }

        /// <summary>
        /// 查询类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryType")]
        public string QueryType{ get; set; }

        /// <summary>
        /// 消耗总内存(bytes)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemCost")]
        public long? MemCost{ get; set; }

        /// <summary>
        /// plan阶段CPU占用(ns)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlanCpuCosts")]
        public long? PlanCpuCosts{ get; set; }

        /// <summary>
        /// plan阶段内存占用(bytes)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlanMemCosts")]
        public long? PlanMemCosts{ get; set; }

        /// <summary>
        /// 执行时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryTime")]
        public long? QueryTime{ get; set; }

        /// <summary>
        /// 资源组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// 获取行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReturnRows")]
        public long? ReturnRows{ get; set; }

        /// <summary>
        /// 扫描数据量(bytes)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanBytes")]
        public long? ScanBytes{ get; set; }

        /// <summary>
        /// 扫描行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScanRows")]
        public long? ScanRows{ get; set; }

        /// <summary>
        /// 开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// 执行状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionState")]
        public string ExecutionState{ get; set; }

        /// <summary>
        /// 执行语句
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionStatement")]
        public string ExecutionStatement{ get; set; }

        /// <summary>
        /// 用户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientIP", this.ClientIP);
            this.SetParamSimple(map, prefix + "CPUCost", this.CPUCost);
            this.SetParamSimple(map, prefix + "DefaultDB", this.DefaultDB);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExecutionIP", this.ExecutionIP);
            this.SetParamSimple(map, prefix + "QueryID", this.QueryID);
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
            this.SetParamSimple(map, prefix + "MemCost", this.MemCost);
            this.SetParamSimple(map, prefix + "PlanCpuCosts", this.PlanCpuCosts);
            this.SetParamSimple(map, prefix + "PlanMemCosts", this.PlanMemCosts);
            this.SetParamSimple(map, prefix + "QueryTime", this.QueryTime);
            this.SetParamSimple(map, prefix + "ResourceGroup", this.ResourceGroup);
            this.SetParamSimple(map, prefix + "ReturnRows", this.ReturnRows);
            this.SetParamSimple(map, prefix + "ScanBytes", this.ScanBytes);
            this.SetParamSimple(map, prefix + "ScanRows", this.ScanRows);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "ExecutionState", this.ExecutionState);
            this.SetParamSimple(map, prefix + "ExecutionStatement", this.ExecutionStatement);
            this.SetParamSimple(map, prefix + "User", this.User);
        }
    }
}

