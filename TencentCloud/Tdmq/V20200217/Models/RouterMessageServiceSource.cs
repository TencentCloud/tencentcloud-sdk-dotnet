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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RouterMessageServiceSource : AbstractModel
    {
        
        /// <summary>
        /// <p>access key</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// <p>mns接入点。<br>需要和router内网联通，一般是公网接入点</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// <p>mns queue名字。<br>可以在https://mns.console.aliyun.com/region/cn-shenzhen/queues 看到</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// <p>secret key</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// <p>是否自动解码mns body。<br>ON：自动解码，复制后的消息内容为解码后的明文。<br>OFF：不用解码，保持Mns消息体原始状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableDecodeBody")]
        public string EnableDecodeBody{ get; set; }

        /// <summary>
        /// <p>mns消费并发数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceConsumeConcurrentThreadCount")]
        public long? SourceConsumeConcurrentThreadCount{ get; set; }

        /// <summary>
        /// <p>过滤时间戳，毫秒级时间戳</p>
        /// </summary>
        [JsonProperty("FilterFromTimestampMs")]
        public long? FilterFromTimestampMs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "EnableDecodeBody", this.EnableDecodeBody);
            this.SetParamSimple(map, prefix + "SourceConsumeConcurrentThreadCount", this.SourceConsumeConcurrentThreadCount);
            this.SetParamSimple(map, prefix + "FilterFromTimestampMs", this.FilterFromTimestampMs);
        }
    }
}

