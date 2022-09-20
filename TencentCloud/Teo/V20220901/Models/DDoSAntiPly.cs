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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSAntiPly : AbstractModel
    {
        
        /// <summary>
        /// tcp协议封禁，取值有：
        /// <li>off ：关闭 ；</li>
        /// <li>on ：开启 。</li>
        /// </summary>
        [JsonProperty("DropTcp")]
        public string DropTcp{ get; set; }

        /// <summary>
        /// udp协议封禁，取值有：
        /// <li>off ：关闭 ；</li>
        /// <li>on ：开启 。</li>
        /// </summary>
        [JsonProperty("DropUdp")]
        public string DropUdp{ get; set; }

        /// <summary>
        /// icmp协议封禁，取值有：
        /// <li>off ：关闭 ；</li>
        /// <li>on ：开启 。</li>
        /// </summary>
        [JsonProperty("DropIcmp")]
        public string DropIcmp{ get; set; }

        /// <summary>
        /// 其他协议封禁，取值有：
        /// <li>off ：关闭 ；</li>
        /// <li>on ：开启 。</li>
        /// </summary>
        [JsonProperty("DropOther")]
        public string DropOther{ get; set; }

        /// <summary>
        /// 源站每秒新连接限速，取值范围0-4294967295。
        /// </summary>
        [JsonProperty("SourceCreateLimit")]
        public long? SourceCreateLimit{ get; set; }

        /// <summary>
        /// 源站并发连接控制，取值范围0-4294967295。
        /// </summary>
        [JsonProperty("SourceConnectLimit")]
        public long? SourceConnectLimit{ get; set; }

        /// <summary>
        /// 目的端口每秒新连接限速，取值范围0-4294967295。
        /// </summary>
        [JsonProperty("DestinationCreateLimit")]
        public long? DestinationCreateLimit{ get; set; }

        /// <summary>
        /// 目的端口并发连接控制，取值范围0-4294967295。
        /// </summary>
        [JsonProperty("DestinationConnectLimit")]
        public long? DestinationConnectLimit{ get; set; }

        /// <summary>
        /// 每秒异常连接数阈值，取值范围0-4294967295。
        /// </summary>
        [JsonProperty("AbnormalConnectNum")]
        public long? AbnormalConnectNum{ get; set; }

        /// <summary>
        /// 异常syn报文百分比阈值，取值范围0-100。
        /// </summary>
        [JsonProperty("AbnormalSynRatio")]
        public long? AbnormalSynRatio{ get; set; }

        /// <summary>
        /// 异常syn报文阈值，取值范围0-65535。
        /// </summary>
        [JsonProperty("AbnormalSynNum")]
        public long? AbnormalSynNum{ get; set; }

        /// <summary>
        /// 每秒连接超时检测，取值范围0-65535。
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public long? ConnectTimeout{ get; set; }

        /// <summary>
        /// 空连接防护开启，取值有：
        /// <li>off ：关闭 ；</li>
        /// <li>on ：开启 。</li>
        /// </summary>
        [JsonProperty("EmptyConnectProtect")]
        public string EmptyConnectProtect{ get; set; }

        /// <summary>
        /// UDP分片开关，取值有：
        /// <li>off ：关闭 ；</li>
        /// <li>on ：开启 。</li>
        /// </summary>
        [JsonProperty("UdpShard")]
        public string UdpShard{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DropTcp", this.DropTcp);
            this.SetParamSimple(map, prefix + "DropUdp", this.DropUdp);
            this.SetParamSimple(map, prefix + "DropIcmp", this.DropIcmp);
            this.SetParamSimple(map, prefix + "DropOther", this.DropOther);
            this.SetParamSimple(map, prefix + "SourceCreateLimit", this.SourceCreateLimit);
            this.SetParamSimple(map, prefix + "SourceConnectLimit", this.SourceConnectLimit);
            this.SetParamSimple(map, prefix + "DestinationCreateLimit", this.DestinationCreateLimit);
            this.SetParamSimple(map, prefix + "DestinationConnectLimit", this.DestinationConnectLimit);
            this.SetParamSimple(map, prefix + "AbnormalConnectNum", this.AbnormalConnectNum);
            this.SetParamSimple(map, prefix + "AbnormalSynRatio", this.AbnormalSynRatio);
            this.SetParamSimple(map, prefix + "AbnormalSynNum", this.AbnormalSynNum);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "EmptyConnectProtect", this.EmptyConnectProtect);
            this.SetParamSimple(map, prefix + "UdpShard", this.UdpShard);
        }
    }
}

