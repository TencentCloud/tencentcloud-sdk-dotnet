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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSAntiPly : AbstractModel
    {
        
        /// <summary>
        /// tcp协议封禁 on-开；off-关
        /// </summary>
        [JsonProperty("DropTcp")]
        public string DropTcp{ get; set; }

        /// <summary>
        /// udp协议封禁 on-开；off-关
        /// </summary>
        [JsonProperty("DropUdp")]
        public string DropUdp{ get; set; }

        /// <summary>
        /// icmp协议封禁 on-开；off-关
        /// </summary>
        [JsonProperty("DropIcmp")]
        public string DropIcmp{ get; set; }

        /// <summary>
        /// 其他协议封禁 on-开；off-关
        /// </summary>
        [JsonProperty("DropOther")]
        public string DropOther{ get; set; }

        /// <summary>
        /// 源每秒新建数限制  0-4294967295
        /// </summary>
        [JsonProperty("SourceCreateLimit")]
        public long? SourceCreateLimit{ get; set; }

        /// <summary>
        /// 源并发连接控制 0-4294967295
        /// </summary>
        [JsonProperty("SourceConnectLimit")]
        public long? SourceConnectLimit{ get; set; }

        /// <summary>
        /// 目的每秒新建数限制 0-4294967295
        /// </summary>
        [JsonProperty("DestinationCreateLimit")]
        public long? DestinationCreateLimit{ get; set; }

        /// <summary>
        /// 目的端口的并发连接控制 0-4294967295
        /// </summary>
        [JsonProperty("DestinationConnectLimit")]
        public long? DestinationConnectLimit{ get; set; }

        /// <summary>
        /// 异常连接数阈值  0-4294967295
        /// </summary>
        [JsonProperty("AbnormalConnectNum")]
        public long? AbnormalConnectNum{ get; set; }

        /// <summary>
        /// syn占比异常阈值 0-100
        /// </summary>
        [JsonProperty("AbnormalSynRatio")]
        public long? AbnormalSynRatio{ get; set; }

        /// <summary>
        /// syn个数异常阈值 0-65535
        /// </summary>
        [JsonProperty("AbnormalSynNum")]
        public long? AbnormalSynNum{ get; set; }

        /// <summary>
        /// 连接超时检测 0-65535
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public long? ConnectTimeout{ get; set; }

        /// <summary>
        /// 空连接防护开启 0-1
        /// </summary>
        [JsonProperty("EmptyConnectProtect")]
        public string EmptyConnectProtect{ get; set; }

        /// <summary>
        /// UDP分片开关；off-关闭，on-开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
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

