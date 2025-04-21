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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOutputSRTSettings : AbstractModel
    {
        
        /// <summary>
        /// 转推的目标地址，当Mode为CALLER时必填，且只能填1组。
        /// </summary>
        [JsonProperty("Destinations")]
        public CreateOutputSRTSettingsDestinations[] Destinations{ get; set; }

        /// <summary>
        /// 转推SRT的流Id，可选大小写字母、数字和特殊字符（.#!:&,=_-），长度为0~512。
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// 转推SRT的延迟，默认120，单位ms，范围为[0, 3000]。此参数同时设置了发送方和接收方的延迟（recvlatency和peerlatency）为相同的值。建议配置为至少3倍RTT，以确保在网络拥塞时能够有效处理数据包的重传和确认
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }

        /// <summary>
        /// 转推SRT的接收延迟，默认120，单位ms，范围为[0, 3000]。 此参数表示接收方用于缓存数据包的时间长度
        /// </summary>
        [JsonProperty("RecvLatency")]
        public long? RecvLatency{ get; set; }

        /// <summary>
        /// 转推SRT的对端延迟，默认120，单位ms，范围为[0, 3000]。 此参数由发送方设置，用于告知接收方其期望的延迟缓冲时间
        /// </summary>
        [JsonProperty("PeerLatency")]
        public long? PeerLatency{ get; set; }

        /// <summary>
        /// 转推SRT的对端空闲超时时间，默认5000，单位ms，范围为[1000, 10000]。 如果连接在设定的超时时间内没有活动，将会被关闭
        /// </summary>
        [JsonProperty("PeerIdleTimeout")]
        public long? PeerIdleTimeout{ get; set; }

        /// <summary>
        /// 转推SRT的加密密钥，默认为空，表示不加密。只可填ascii码值，长度为[10, 79]。
        /// </summary>
        [JsonProperty("Passphrase")]
        public string Passphrase{ get; set; }

        /// <summary>
        /// 转推SRT的密钥长度，默认为0，可选[0|16|24|32]。
        /// </summary>
        [JsonProperty("PbKeyLen")]
        public long? PbKeyLen{ get; set; }

        /// <summary>
        /// SRT模式，可选[LISTENER|CALLER]，默认为CALLER。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Destinations.", this.Destinations);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
            this.SetParamSimple(map, prefix + "RecvLatency", this.RecvLatency);
            this.SetParamSimple(map, prefix + "PeerLatency", this.PeerLatency);
            this.SetParamSimple(map, prefix + "PeerIdleTimeout", this.PeerIdleTimeout);
            this.SetParamSimple(map, prefix + "Passphrase", this.Passphrase);
            this.SetParamSimple(map, prefix + "PbKeyLen", this.PbKeyLen);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

