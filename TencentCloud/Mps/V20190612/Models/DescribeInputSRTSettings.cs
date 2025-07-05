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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInputSRTSettings : AbstractModel
    {
        
        /// <summary>
        /// SRT模式。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 流Id。
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// 延迟。
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }

        /// <summary>
        /// 接收延迟。
        /// </summary>
        [JsonProperty("RecvLatency")]
        public long? RecvLatency{ get; set; }

        /// <summary>
        /// 对端延迟。
        /// </summary>
        [JsonProperty("PeerLatency")]
        public long? PeerLatency{ get; set; }

        /// <summary>
        /// 对端空闲超时时间。
        /// </summary>
        [JsonProperty("PeerIdleTimeout")]
        public long? PeerIdleTimeout{ get; set; }

        /// <summary>
        /// 解密密钥。
        /// </summary>
        [JsonProperty("Passphrase")]
        public string Passphrase{ get; set; }

        /// <summary>
        /// 密钥长度。
        /// </summary>
        [JsonProperty("PbKeyLen")]
        public long? PbKeyLen{ get; set; }

        /// <summary>
        /// SRT对端地址。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceAddresses")]
        public SRTSourceAddressResp[] SourceAddresses{ get; set; }

        /// <summary>
        /// FEC  设置
        /// </summary>
        [JsonProperty("FEC")]
        public SRTFECSimpleOptions FEC{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
            this.SetParamSimple(map, prefix + "RecvLatency", this.RecvLatency);
            this.SetParamSimple(map, prefix + "PeerLatency", this.PeerLatency);
            this.SetParamSimple(map, prefix + "PeerIdleTimeout", this.PeerIdleTimeout);
            this.SetParamSimple(map, prefix + "Passphrase", this.Passphrase);
            this.SetParamSimple(map, prefix + "PbKeyLen", this.PbKeyLen);
            this.SetParamArrayObj(map, prefix + "SourceAddresses.", this.SourceAddresses);
            this.SetParamObj(map, prefix + "FEC.", this.FEC);
        }
    }
}

