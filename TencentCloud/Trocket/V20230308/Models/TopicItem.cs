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

    public class TopicItem : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 主题类型
        /// NORMAL:普通消息,
        /// FIFO:顺序消息,
        /// DELAY:延时消息,
        /// TRANSACTION:事务消息
        /// </summary>
        [JsonProperty("TopicType")]
        public string TopicType{ get; set; }

        /// <summary>
        /// 队列数量
        /// </summary>
        [JsonProperty("QueueNum")]
        public long? QueueNum{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 4.x的集群id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterIdV4")]
        public string ClusterIdV4{ get; set; }

        /// <summary>
        /// 4.x的命名空间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NamespaceV4")]
        public string NamespaceV4{ get; set; }

        /// <summary>
        /// 4.x的主题名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicV4")]
        public string TopicV4{ get; set; }

        /// <summary>
        /// 4.x的完整命名空间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FullNamespaceV4")]
        public string FullNamespaceV4{ get; set; }

        /// <summary>
        /// 消息保留时长
        /// </summary>
        [JsonProperty("MsgTTL")]
        public long? MsgTTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "TopicType", this.TopicType);
            this.SetParamSimple(map, prefix + "QueueNum", this.QueueNum);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ClusterIdV4", this.ClusterIdV4);
            this.SetParamSimple(map, prefix + "NamespaceV4", this.NamespaceV4);
            this.SetParamSimple(map, prefix + "TopicV4", this.TopicV4);
            this.SetParamSimple(map, prefix + "FullNamespaceV4", this.FullNamespaceV4);
            this.SetParamSimple(map, prefix + "MsgTTL", this.MsgTTL);
        }
    }
}

