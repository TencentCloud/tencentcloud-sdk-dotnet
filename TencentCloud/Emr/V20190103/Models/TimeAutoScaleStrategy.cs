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

    public class TimeAutoScaleStrategy : AbstractModel
    {
        
        /// <summary>
        /// 策略名字，集群内唯一。
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// 策略触发后的冷却时间，该段时间内，将不能触发弹性扩缩容。
        /// </summary>
        [JsonProperty("IntervalTime")]
        public ulong? IntervalTime{ get; set; }

        /// <summary>
        /// 扩缩容动作，1表示扩容，2表示缩容。
        /// </summary>
        [JsonProperty("ScaleAction")]
        public ulong? ScaleAction{ get; set; }

        /// <summary>
        /// 扩缩容数量。
        /// </summary>
        [JsonProperty("ScaleNum")]
        public ulong? ScaleNum{ get; set; }

        /// <summary>
        /// 规则状态，1表示有效，2表示无效，3表示暂停。必须填写
        /// </summary>
        [JsonProperty("StrategyStatus")]
        public ulong? StrategyStatus{ get; set; }

        /// <summary>
        /// 规则优先级，越小越高。
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// 当多条规则同时触发，其中某些未真正执行时，在该时间范围内，将会重试。
        /// </summary>
        [JsonProperty("RetryValidTime")]
        public ulong? RetryValidTime{ get; set; }

        /// <summary>
        /// 时间扩缩容重复策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RepeatStrategy")]
        public RepeatStrategy RepeatStrategy{ get; set; }

        /// <summary>
        /// 策略唯一ID。
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

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
        /// 销毁策略, "DEFAULT",默认销毁策略，由缩容规则触发缩容，"TIMING"表示定时销毁
        /// </summary>
        [JsonProperty("TerminatePolicy")]
        public string TerminatePolicy{ get; set; }

        /// <summary>
        /// 最长使用时间， 秒数，最短1小时，最长24小时
        /// </summary>
        [JsonProperty("MaxUse")]
        public long? MaxUse{ get; set; }

        /// <summary>
        /// 节点部署服务列表。部署服务仅填写HDFS、YARN。[组件名对应的映射关系表](https://cloud.tencent.com/document/product/589/98760)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public long?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// 启动进程列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public long?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// 补偿扩容，0表示不开启，1表示开启
        /// </summary>
        [JsonProperty("CompensateFlag")]
        public long? CompensateFlag{ get; set; }

        /// <summary>
        /// 伸缩组id
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "ScaleAction", this.ScaleAction);
            this.SetParamSimple(map, prefix + "ScaleNum", this.ScaleNum);
            this.SetParamSimple(map, prefix + "StrategyStatus", this.StrategyStatus);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "RetryValidTime", this.RetryValidTime);
            this.SetParamObj(map, prefix + "RepeatStrategy.", this.RepeatStrategy);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "GraceDownFlag", this.GraceDownFlag);
            this.SetParamSimple(map, prefix + "GraceDownTime", this.GraceDownTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ConfigGroupAssigned", this.ConfigGroupAssigned);
            this.SetParamSimple(map, prefix + "MeasureMethod", this.MeasureMethod);
            this.SetParamSimple(map, prefix + "TerminatePolicy", this.TerminatePolicy);
            this.SetParamSimple(map, prefix + "MaxUse", this.MaxUse);
            this.SetParamArraySimple(map, prefix + "SoftDeployInfo.", this.SoftDeployInfo);
            this.SetParamArraySimple(map, prefix + "ServiceNodeInfo.", this.ServiceNodeInfo);
            this.SetParamSimple(map, prefix + "CompensateFlag", this.CompensateFlag);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
        }
    }
}

