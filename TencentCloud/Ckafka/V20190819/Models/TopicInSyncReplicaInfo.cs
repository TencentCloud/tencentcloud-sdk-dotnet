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

    public class TopicInSyncReplicaInfo : AbstractModel
    {
        
        /// <summary>
        /// 分区名称
        /// </summary>
        [JsonProperty("Partition")]
        public string Partition{ get; set; }

        /// <summary>
        /// Leader Id
        /// </summary>
        [JsonProperty("Leader")]
        public ulong? Leader{ get; set; }

        /// <summary>
        /// 副本集
        /// </summary>
        [JsonProperty("Replica")]
        public string Replica{ get; set; }

        /// <summary>
        /// ISR
        /// </summary>
        [JsonProperty("InSyncReplica")]
        public string InSyncReplica{ get; set; }

        /// <summary>
        /// 起始Offset
        /// </summary>
        [JsonProperty("BeginOffset")]
        public ulong? BeginOffset{ get; set; }

        /// <summary>
        /// 末端Offset
        /// </summary>
        [JsonProperty("EndOffset")]
        public ulong? EndOffset{ get; set; }

        /// <summary>
        /// 消息数
        /// </summary>
        [JsonProperty("MessageCount")]
        public ulong? MessageCount{ get; set; }

        /// <summary>
        /// 未同步副本集
        /// </summary>
        [JsonProperty("OutOfSyncReplica")]
        public string OutOfSyncReplica{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamSimple(map, prefix + "Leader", this.Leader);
            this.SetParamSimple(map, prefix + "Replica", this.Replica);
            this.SetParamSimple(map, prefix + "InSyncReplica", this.InSyncReplica);
            this.SetParamSimple(map, prefix + "BeginOffset", this.BeginOffset);
            this.SetParamSimple(map, prefix + "EndOffset", this.EndOffset);
            this.SetParamSimple(map, prefix + "MessageCount", this.MessageCount);
            this.SetParamSimple(map, prefix + "OutOfSyncReplica", this.OutOfSyncReplica);
        }
    }
}

