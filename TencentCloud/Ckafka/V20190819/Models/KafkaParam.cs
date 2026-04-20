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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KafkaParam : AbstractModel
    {
        
        /// <summary>
        /// <p>是否为自建集群</p>
        /// </summary>
        [JsonProperty("SelfBuilt")]
        public bool? SelfBuilt{ get; set; }

        /// <summary>
        /// <p>ckafka集群实例Id</p>
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// <p>主题名，多个以“,”分隔</p>
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// <p>Offset类型，最开始位置earliest，最新位置latest，时间点位置timestamp</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OffsetType")]
        public string OffsetType{ get; set; }

        /// <summary>
        /// <p>Offset类型为timestamp时必传，传时间戳，精确到秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// <p>实例资源名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// <p>可用区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>主题Id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Topic的分区数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartitionNum")]
        public long? PartitionNum{ get; set; }

        /// <summary>
        /// <p>启用容错实例/开启死信队列</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableToleration")]
        public bool? EnableToleration{ get; set; }

        /// <summary>
        /// <p>Qps 限制</p>
        /// </summary>
        [JsonProperty("QpsLimit")]
        public ulong? QpsLimit{ get; set; }

        /// <summary>
        /// <p>Table到Topic的路由，「分发到多个topic」开关打开时必传</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableMappings")]
        public TableMapping[] TableMappings{ get; set; }

        /// <summary>
        /// <p>「分发到多个topic」开关，默认为false</p>
        /// </summary>
        [JsonProperty("UseTableMapping")]
        public bool? UseTableMapping{ get; set; }

        /// <summary>
        /// <p>使用的Topic是否需要自动创建（目前只支持SOURCE流入任务，如果不使用分发到多个topic，需要在Topic字段填写需要自动创建的topic名）</p>
        /// </summary>
        [JsonProperty("UseAutoCreateTopic")]
        public bool? UseAutoCreateTopic{ get; set; }

        /// <summary>
        /// <p>写入Topic时是否进行压缩，不开启填&quot;none&quot;，开启的话，填写&quot;open&quot;。</p>
        /// </summary>
        [JsonProperty("CompressionType")]
        public string CompressionType{ get; set; }

        /// <summary>
        /// <p>源topic消息1条扩增成msgMultiple条写入目标topic(该参数目前只有ckafka流入ckafka适用)</p>
        /// </summary>
        [JsonProperty("MsgMultiple")]
        public long? MsgMultiple{ get; set; }

        /// <summary>
        /// <p>数据同步专用参数, 正常数据处理可为空, 实例级别同步: 仅同步元数据填写&quot;META_SYNC_INSTANCE_TYPE&quot;, 同步元数据及全部topic内消息的填写&quot;META_AND_DATA_SYNC_INSTANCE_TYPE&quot;; topic级别同步: 选中的源和目标topic中的消息(需要目标实例也包含该topic)填写&quot;DATA_SYNC_TYPE&quot;</p>
        /// </summary>
        [JsonProperty("ConnectorSyncType")]
        public string ConnectorSyncType{ get; set; }

        /// <summary>
        /// <p>数据同步专用参数, 当通过时,希望下游的消息写入分区与上游的一致,则填true,但下游分区小于上游时,会报错; 不需要一致则为false, 默认为false</p>
        /// </summary>
        [JsonProperty("KeepPartition")]
        public bool? KeepPartition{ get; set; }

        /// <summary>
        /// <p>正则匹配Topic列表</p>
        /// </summary>
        [JsonProperty("TopicRegularExpression")]
        public string TopicRegularExpression{ get; set; }

        /// <summary>
        /// <p>Topic 前缀</p>
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }

        /// <summary>
        /// <p>Topic前缀分隔符</p>
        /// </summary>
        [JsonProperty("Separator")]
        public string Separator{ get; set; }

        /// <summary>
        /// <p>多选topic列表</p>
        /// </summary>
        [JsonProperty("TopicList")]
        public string[] TopicList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SelfBuilt", this.SelfBuilt);
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "OffsetType", this.OffsetType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
            this.SetParamSimple(map, prefix + "EnableToleration", this.EnableToleration);
            this.SetParamSimple(map, prefix + "QpsLimit", this.QpsLimit);
            this.SetParamArrayObj(map, prefix + "TableMappings.", this.TableMappings);
            this.SetParamSimple(map, prefix + "UseTableMapping", this.UseTableMapping);
            this.SetParamSimple(map, prefix + "UseAutoCreateTopic", this.UseAutoCreateTopic);
            this.SetParamSimple(map, prefix + "CompressionType", this.CompressionType);
            this.SetParamSimple(map, prefix + "MsgMultiple", this.MsgMultiple);
            this.SetParamSimple(map, prefix + "ConnectorSyncType", this.ConnectorSyncType);
            this.SetParamSimple(map, prefix + "KeepPartition", this.KeepPartition);
            this.SetParamSimple(map, prefix + "TopicRegularExpression", this.TopicRegularExpression);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
            this.SetParamSimple(map, prefix + "Separator", this.Separator);
            this.SetParamArraySimple(map, prefix + "TopicList.", this.TopicList);
        }
    }
}

