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

    public class ConsumeGroupItem : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>消费组名称</p>
        /// </summary>
        [JsonProperty("ConsumerGroup")]
        public string ConsumerGroup{ get; set; }

        /// <summary>
        /// <p>是否开启消费</p>
        /// </summary>
        [JsonProperty("ConsumeEnable")]
        public bool? ConsumeEnable{ get; set; }

        /// <summary>
        /// <p>顺序投递：true<br>并发投递：false</p>
        /// </summary>
        [JsonProperty("ConsumeMessageOrderly")]
        public bool? ConsumeMessageOrderly{ get; set; }

        /// <summary>
        /// <p>最大重试次数</p>
        /// </summary>
        [JsonProperty("MaxRetryTimes")]
        public long? MaxRetryTimes{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>4.x的集群ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterIdV4")]
        public string ClusterIdV4{ get; set; }

        /// <summary>
        /// <p>4.x的命名空间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NamespaceV4")]
        public string NamespaceV4{ get; set; }

        /// <summary>
        /// <p>4.x的消费组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumerGroupV4")]
        public string ConsumerGroupV4{ get; set; }

        /// <summary>
        /// <p>4.x的完整命名空间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FullNamespaceV4")]
        public string FullNamespaceV4{ get; set; }

        /// <summary>
        /// <p>订阅的主题个数</p>
        /// </summary>
        [JsonProperty("SubscribeTopicNum")]
        public long? SubscribeTopicNum{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>绑定的标签列表</p>
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// <p>重试策略</p>
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public RetryPolicy RetryPolicy{ get; set; }

        /// <summary>
        /// <p>消费模式，枚举值如下：</p><ul><li>CLUSTERING：集群/广播消费</li><li>LITE：LiteTopic 消费</li></ul>
        /// </summary>
        [JsonProperty("ConsumeModel")]
        public string ConsumeModel{ get; set; }

        /// <summary>
        /// <p>自定义的死信Topic名称</p>
        /// </summary>
        [JsonProperty("DeadLetterTargetTopic")]
        public string DeadLetterTargetTopic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ConsumerGroup", this.ConsumerGroup);
            this.SetParamSimple(map, prefix + "ConsumeEnable", this.ConsumeEnable);
            this.SetParamSimple(map, prefix + "ConsumeMessageOrderly", this.ConsumeMessageOrderly);
            this.SetParamSimple(map, prefix + "MaxRetryTimes", this.MaxRetryTimes);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ClusterIdV4", this.ClusterIdV4);
            this.SetParamSimple(map, prefix + "NamespaceV4", this.NamespaceV4);
            this.SetParamSimple(map, prefix + "ConsumerGroupV4", this.ConsumerGroupV4);
            this.SetParamSimple(map, prefix + "FullNamespaceV4", this.FullNamespaceV4);
            this.SetParamSimple(map, prefix + "SubscribeTopicNum", this.SubscribeTopicNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamObj(map, prefix + "RetryPolicy.", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "ConsumeModel", this.ConsumeModel);
            this.SetParamSimple(map, prefix + "DeadLetterTargetTopic", this.DeadLetterTargetTopic);
        }
    }
}

