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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadAutoScaleStrategy : AbstractModel
    {
        
        /// <summary>
        /// 规则ID。
        /// </summary>
        [JsonProperty("StrategyId")]
        public long? StrategyId{ get; set; }

        /// <summary>
        /// 规则名称。
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// 规则生效冷却时间。
        /// </summary>
        [JsonProperty("CalmDownTime")]
        public long? CalmDownTime{ get; set; }

        /// <summary>
        /// 扩缩容动作，1表示扩容，2表示缩容。
        /// </summary>
        [JsonProperty("ScaleAction")]
        public long? ScaleAction{ get; set; }

        /// <summary>
        /// 每次规则生效时的扩缩容数量。
        /// </summary>
        [JsonProperty("ScaleNum")]
        public long? ScaleNum{ get; set; }

        /// <summary>
        /// 指标处理方法，1表示MAX，2表示MIN，3表示AVG。
        /// </summary>
        [JsonProperty("ProcessMethod")]
        public long? ProcessMethod{ get; set; }

        /// <summary>
        /// 规则优先级，添加时无效，默认为自增。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 规则状态，1表示启动，3表示禁用。
        /// </summary>
        [JsonProperty("StrategyStatus")]
        public long? StrategyStatus{ get; set; }

        /// <summary>
        /// 规则扩容指定 yarn node label
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// 规则生效的有效时间
        /// </summary>
        [JsonProperty("PeriodValid")]
        public string PeriodValid{ get; set; }

        /// <summary>
        /// 优雅缩容开关
        /// </summary>
        [JsonProperty("GraceDownFlag")]
        public bool? GraceDownFlag{ get; set; }

        /// <summary>
        /// 优雅缩容等待时间
        /// </summary>
        [JsonProperty("GraceDownTime")]
        public long? GraceDownTime{ get; set; }

        /// <summary>
        /// 是否开启任务保护
        /// </summary>
        [JsonProperty("GraceDownProtectFlag")]
        public bool? GraceDownProtectFlag{ get; set; }

        /// <summary>
        /// 绑定标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 预设配置组
        /// </summary>
        [JsonProperty("ConfigGroupAssigned")]
        public string ConfigGroupAssigned{ get; set; }

        /// <summary>
        /// 扩容资源计算方法，"DEFAULT","INSTANCE", "CPU", "MEMORYGB"。
        /// "DEFAULT"表示默认方式，与"INSTANCE"意义相同。
        /// "INSTANCE"表示按照节点计算，默认方式。
        /// "CPU"表示按照机器的核数计算。
        /// "MEMORYGB"表示按照机器内存数计算。
        /// </summary>
        [JsonProperty("MeasureMethod")]
        public string MeasureMethod{ get; set; }

        /// <summary>
        /// 节点部署服务列表，例如["HDFS-3.1.2","YARN-3.1.2"]。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SoftDeployDesc")]
        public string[] SoftDeployDesc{ get; set; }

        /// <summary>
        /// 启动进程列表，例如["NodeManager"]。
        /// </summary>
        [JsonProperty("ServiceNodeDesc")]
        public string ServiceNodeDesc{ get; set; }

        /// <summary>
        /// 启动进程列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public long?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// 节点部署服务列表。部署服务仅填写HDFS、YARN。[组件名对应的映射关系表](https://cloud.tencent.com/document/product/589/98760)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public long?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// 多指标触发条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadMetricsConditions")]
        public LoadMetricsConditions LoadMetricsConditions{ get; set; }

        /// <summary>
        /// 伸缩组Id
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// soft例如yarn
        /// </summary>
        [JsonProperty("Soft")]
        public string Soft{ get; set; }

        /// <summary>
        /// 任务保护时间
        /// </summary>
        [JsonProperty("GraceDownProtectTime")]
        public long? GraceDownProtectTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "CalmDownTime", this.CalmDownTime);
            this.SetParamSimple(map, prefix + "ScaleAction", this.ScaleAction);
            this.SetParamSimple(map, prefix + "ScaleNum", this.ScaleNum);
            this.SetParamSimple(map, prefix + "ProcessMethod", this.ProcessMethod);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "StrategyStatus", this.StrategyStatus);
            this.SetParamSimple(map, prefix + "YarnNodeLabel", this.YarnNodeLabel);
            this.SetParamSimple(map, prefix + "PeriodValid", this.PeriodValid);
            this.SetParamSimple(map, prefix + "GraceDownFlag", this.GraceDownFlag);
            this.SetParamSimple(map, prefix + "GraceDownTime", this.GraceDownTime);
            this.SetParamSimple(map, prefix + "GraceDownProtectFlag", this.GraceDownProtectFlag);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ConfigGroupAssigned", this.ConfigGroupAssigned);
            this.SetParamSimple(map, prefix + "MeasureMethod", this.MeasureMethod);
            this.SetParamArraySimple(map, prefix + "SoftDeployDesc.", this.SoftDeployDesc);
            this.SetParamSimple(map, prefix + "ServiceNodeDesc", this.ServiceNodeDesc);
            this.SetParamArraySimple(map, prefix + "ServiceNodeInfo.", this.ServiceNodeInfo);
            this.SetParamArraySimple(map, prefix + "SoftDeployInfo.", this.SoftDeployInfo);
            this.SetParamObj(map, prefix + "LoadMetricsConditions.", this.LoadMetricsConditions);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Soft", this.Soft);
            this.SetParamSimple(map, prefix + "GraceDownProtectTime", this.GraceDownProtectTime);
        }
    }
}

