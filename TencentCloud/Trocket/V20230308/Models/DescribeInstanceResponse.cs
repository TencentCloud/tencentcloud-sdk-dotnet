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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例类型，
        /// EXPERIMENT 体验版
        /// BASIC 基础版
        /// PRO  专业版
        /// PLATINUM 铂金版
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 主题数量
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// 实例最大主题数量
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// 消费组数量
        /// </summary>
        [JsonProperty("GroupNum")]
        public long? GroupNum{ get; set; }

        /// <summary>
        /// 实例最大消费组数量
        /// </summary>
        [JsonProperty("GroupNumLimit")]
        public long? GroupNumLimit{ get; set; }

        /// <summary>
        /// 消息保留时间，小时为单位
        /// </summary>
        [JsonProperty("MessageRetention")]
        public long? MessageRetention{ get; set; }

        /// <summary>
        /// 最大可调整消息保留时间，小时为单位
        /// </summary>
        [JsonProperty("RetentionUpperLimit")]
        public long? RetentionUpperLimit{ get; set; }

        /// <summary>
        /// 最小可调整消息保留时间，小时为单位
        /// </summary>
        [JsonProperty("RetentionLowerLimit")]
        public long? RetentionLowerLimit{ get; set; }

        /// <summary>
        /// TPS限流值
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// 弹性TPS限流值
        /// </summary>
        [JsonProperty("ScaledTpsLimit")]
        public long? ScaledTpsLimit{ get; set; }

        /// <summary>
        /// 延迟消息最长时间，小时为单位
        /// </summary>
        [JsonProperty("MaxMessageDelay")]
        public long? MaxMessageDelay{ get; set; }

        /// <summary>
        /// 创建时间，**Unix时间戳（毫秒）**
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// 消息发送接收比例
        /// </summary>
        [JsonProperty("SendReceiveRatio")]
        public float? SendReceiveRatio{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// 接入点列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndpointList")]
        public Endpoint[] EndpointList{ get; set; }

        /// <summary>
        /// 主题队列数上限
        /// </summary>
        [JsonProperty("TopicQueueNumUpperLimit")]
        public long? TopicQueueNumUpperLimit{ get; set; }

        /// <summary>
        /// 主题队列数下限
        /// </summary>
        [JsonProperty("TopicQueueNumLowerLimit")]
        public long? TopicQueueNumLowerLimit{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 实例状态，枚举值如下：
        /// 
        /// - RUNNING：运行中
        /// - ABNORMAL：异常
        /// - OVERDUE：隔离中
        /// - DESTROYED：已销毁
        /// - CREATING：创建中
        /// - MODIFYING：变配中
        /// - CREATE_FAILURE：创建失败
        /// - MODIFY_FAILURE：变配失败
        /// - DELETING：删除中
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// 实例规格
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// 计费模式，枚举值如下：
        /// 
        /// - POSTPAID：后付费按量计费
        /// - PREPAID：预付费包年包月
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 是否开启弹性TPS
        /// </summary>
        [JsonProperty("ScaledTpsEnabled")]
        public bool? ScaledTpsEnabled{ get; set; }

        /// <summary>
        /// 预付费集群是否自动续费，枚举值如下：
        /// 
        /// - 0: 不自动续费
        /// - 1: 自动续费
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// 到期时间，**Unix时间戳（毫秒）**
        /// </summary>
        [JsonProperty("ExpiryTime")]
        public long? ExpiryTime{ get; set; }

        /// <summary>
        /// 角色数量限制
        /// </summary>
        [JsonProperty("RoleNumLimit")]
        public long? RoleNumLimit{ get; set; }

        /// <summary>
        /// 是否开启 ACL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AclEnabled")]
        public bool? AclEnabled{ get; set; }

        /// <summary>
        /// topic个数免费额度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicNumLowerLimit")]
        public long? TopicNumLowerLimit{ get; set; }

        /// <summary>
        /// 最大可设置的topic个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicNumUpperLimit")]
        public long? TopicNumUpperLimit{ get; set; }

        /// <summary>
        /// 所属可用区列表，参考 [DescribeZones](https://cloud.tencent.com/document/product/1596/77929) 接口返回中的 [ZoneInfo](https://cloud.tencent.com/document/api/1596/77932#ZoneInfo) 数据结构。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// proxy节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// proxy调度详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneScheduledList")]
        public ZoneScheduledItem[] ZoneScheduledList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "TopicNumLimit", this.TopicNumLimit);
            this.SetParamSimple(map, prefix + "GroupNum", this.GroupNum);
            this.SetParamSimple(map, prefix + "GroupNumLimit", this.GroupNumLimit);
            this.SetParamSimple(map, prefix + "MessageRetention", this.MessageRetention);
            this.SetParamSimple(map, prefix + "RetentionUpperLimit", this.RetentionUpperLimit);
            this.SetParamSimple(map, prefix + "RetentionLowerLimit", this.RetentionLowerLimit);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "ScaledTpsLimit", this.ScaledTpsLimit);
            this.SetParamSimple(map, prefix + "MaxMessageDelay", this.MaxMessageDelay);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "SendReceiveRatio", this.SendReceiveRatio);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArrayObj(map, prefix + "EndpointList.", this.EndpointList);
            this.SetParamSimple(map, prefix + "TopicQueueNumUpperLimit", this.TopicQueueNumUpperLimit);
            this.SetParamSimple(map, prefix + "TopicQueueNumLowerLimit", this.TopicQueueNumLowerLimit);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ScaledTpsEnabled", this.ScaledTpsEnabled);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ExpiryTime", this.ExpiryTime);
            this.SetParamSimple(map, prefix + "RoleNumLimit", this.RoleNumLimit);
            this.SetParamSimple(map, prefix + "AclEnabled", this.AclEnabled);
            this.SetParamSimple(map, prefix + "TopicNumLowerLimit", this.TopicNumLowerLimit);
            this.SetParamSimple(map, prefix + "TopicNumUpperLimit", this.TopicNumUpperLimit);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamArrayObj(map, prefix + "ZoneScheduledList.", this.ZoneScheduledList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

