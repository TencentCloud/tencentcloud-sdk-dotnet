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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogstashPipeline : AbstractModel
    {
        
        /// <summary>
        /// 管道ID
        /// </summary>
        [JsonProperty("PipelineId")]
        public string PipelineId{ get; set; }

        /// <summary>
        /// 管道描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PipelineDesc")]
        public string PipelineDesc{ get; set; }

        /// <summary>
        /// 管道配置内容
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 管道的Worker数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Workers")]
        public ulong? Workers{ get; set; }

        /// <summary>
        /// 管道批处理大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchSize")]
        public ulong? BatchSize{ get; set; }

        /// <summary>
        /// 管道批处理延迟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchDelay")]
        public ulong? BatchDelay{ get; set; }

        /// <summary>
        /// 管道缓冲队列类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueType")]
        public string QueueType{ get; set; }

        /// <summary>
        /// 管道缓冲队列大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueMaxBytes")]
        public string QueueMaxBytes{ get; set; }

        /// <summary>
        /// 管道缓冲队列检查点写入数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueCheckPointWrites")]
        public ulong? QueueCheckPointWrites{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PipelineId", this.PipelineId);
            this.SetParamSimple(map, prefix + "PipelineDesc", this.PipelineDesc);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Workers", this.Workers);
            this.SetParamSimple(map, prefix + "BatchSize", this.BatchSize);
            this.SetParamSimple(map, prefix + "BatchDelay", this.BatchDelay);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "QueueMaxBytes", this.QueueMaxBytes);
            this.SetParamSimple(map, prefix + "QueueCheckPointWrites", this.QueueCheckPointWrites);
        }
    }
}

