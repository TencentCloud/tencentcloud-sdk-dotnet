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

    public class ExportRocketMQMessageDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 消息id
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// 消息生成时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BornTimestamp")]
        public long? BornTimestamp{ get; set; }

        /// <summary>
        /// 消息存储时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StoreTimestamp")]
        public long? StoreTimestamp{ get; set; }

        /// <summary>
        /// 消息生产客户端地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BornHost")]
        public string BornHost{ get; set; }

        /// <summary>
        /// 消息Tag
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgTag")]
        public string MsgTag{ get; set; }

        /// <summary>
        /// 消息Key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgKey")]
        public string MsgKey{ get; set; }

        /// <summary>
        /// 消息属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Properties")]
        public string Properties{ get; set; }

        /// <summary>
        /// 消息重试次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReConsumeTimes")]
        public ulong? ReConsumeTimes{ get; set; }

        /// <summary>
        /// Base64编码格式字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgBody")]
        public string MsgBody{ get; set; }

        /// <summary>
        /// 消息内容的CRC32 Code
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MsgBodyCRC")]
        public long? MsgBodyCRC{ get; set; }

        /// <summary>
        /// 消息体大小（单位K）
        /// 当大于2048时不返回消息
        /// </summary>
        [JsonProperty("MsgBodySize")]
        public ulong? MsgBodySize{ get; set; }

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
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "BornTimestamp", this.BornTimestamp);
            this.SetParamSimple(map, prefix + "StoreTimestamp", this.StoreTimestamp);
            this.SetParamSimple(map, prefix + "BornHost", this.BornHost);
            this.SetParamSimple(map, prefix + "MsgTag", this.MsgTag);
            this.SetParamSimple(map, prefix + "MsgKey", this.MsgKey);
            this.SetParamSimple(map, prefix + "Properties", this.Properties);
            this.SetParamSimple(map, prefix + "ReConsumeTimes", this.ReConsumeTimes);
            this.SetParamSimple(map, prefix + "MsgBody", this.MsgBody);
            this.SetParamSimple(map, prefix + "MsgBodyCRC", this.MsgBodyCRC);
            this.SetParamSimple(map, prefix + "MsgBodySize", this.MsgBodySize);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

