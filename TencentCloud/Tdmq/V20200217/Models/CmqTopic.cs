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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CmqTopic : AbstractModel
    {
        
        /// <summary>
        /// 主题的 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 主题名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 消息在主题中最长存活时间，从发送到该主题开始经过此参数指定的时间后，不论消息是否被成功推送给用户都将被删除，单位为秒。固定为一天（86400秒），该属性不能修改。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// 消息最大长度。取值范围1024 - 1048576Byte（即1 - 1024K），默认值为65536。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// 每秒钟发布消息的条数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// 描述用户创建订阅时选择的过滤策略：
        /// FilterType = 1表示用户使用 FilterTag 标签过滤;
        /// FilterType = 2表示用户使用 BindingKey 过滤。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterType")]
        public ulong? FilterType{ get; set; }

        /// <summary>
        /// 主题的创建时间。返回 Unix 时间戳，精确到毫秒。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 最后一次修改主题属性的时间。返回 Unix 时间戳，精确到毫秒。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public ulong? LastModifyTime{ get; set; }

        /// <summary>
        /// 当前该主题中消息数目（消息堆积数）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgCount")]
        public ulong? MsgCount{ get; set; }

        /// <summary>
        /// 创建者 Uin，CAM 鉴权 resource 由该字段组合而成。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateUin")]
        public ulong? CreateUin{ get; set; }

        /// <summary>
        /// 关联的标签。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 消息轨迹。true表示开启，false表示不开启。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Trace")]
        public bool? Trace{ get; set; }

        /// <summary>
        /// 租户id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// 命名空间名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 集群状态，0:创建中，1:正常，2:销毁中，3:已删除，4: 隔离中，5:创建失败，6: 删除失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 0表示pulsar，1表示rocketmq
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerType")]
        public long? BrokerType{ get; set; }

        /// <summary>
        /// 订阅数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubscriptionCount")]
        public long? SubscriptionCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "MsgRetentionSeconds", this.MsgRetentionSeconds);
            this.SetParamSimple(map, prefix + "MaxMsgSize", this.MaxMsgSize);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastModifyTime", this.LastModifyTime);
            this.SetParamSimple(map, prefix + "MsgCount", this.MsgCount);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Trace", this.Trace);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BrokerType", this.BrokerType);
            this.SetParamSimple(map, prefix + "SubscriptionCount", this.SubscriptionCount);
        }
    }
}

