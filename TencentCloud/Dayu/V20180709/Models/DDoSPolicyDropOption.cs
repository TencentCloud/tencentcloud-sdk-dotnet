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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSPolicyDropOption : AbstractModel
    {
        
        /// <summary>
        /// 禁用TCP协议，取值范围[0,1]
        /// </summary>
        [JsonProperty("DropTcp")]
        public ulong? DropTcp{ get; set; }

        /// <summary>
        /// 禁用UDP协议，取值范围[0,1]
        /// </summary>
        [JsonProperty("DropUdp")]
        public ulong? DropUdp{ get; set; }

        /// <summary>
        /// 禁用ICMP协议，取值范围[0,1]
        /// </summary>
        [JsonProperty("DropIcmp")]
        public ulong? DropIcmp{ get; set; }

        /// <summary>
        /// 禁用其他协议，取值范围[0,1]
        /// </summary>
        [JsonProperty("DropOther")]
        public ulong? DropOther{ get; set; }

        /// <summary>
        /// 拒绝海外流量，取值范围[0,1]
        /// </summary>
        [JsonProperty("DropAbroad")]
        public ulong? DropAbroad{ get; set; }

        /// <summary>
        /// 空连接防护，取值范围[0,1]
        /// </summary>
        [JsonProperty("CheckSyncConn")]
        public ulong? CheckSyncConn{ get; set; }

        /// <summary>
        /// 基于来源IP及目的IP的新建连接抑制，取值范围[0,4294967295]
        /// </summary>
        [JsonProperty("SdNewLimit")]
        public ulong? SdNewLimit{ get; set; }

        /// <summary>
        /// 基于目的IP的新建连接抑制，取值范围[0,4294967295]
        /// </summary>
        [JsonProperty("DstNewLimit")]
        public ulong? DstNewLimit{ get; set; }

        /// <summary>
        /// 基于来源IP及目的IP的并发连接抑制，取值范围[0,4294967295]
        /// </summary>
        [JsonProperty("SdConnLimit")]
        public ulong? SdConnLimit{ get; set; }

        /// <summary>
        /// 基于目的IP的并发连接抑制，取值范围[0,4294967295]
        /// </summary>
        [JsonProperty("DstConnLimit")]
        public ulong? DstConnLimit{ get; set; }

        /// <summary>
        /// 基于连接抑制触发阈值，取值范围[0,4294967295]
        /// </summary>
        [JsonProperty("BadConnThreshold")]
        public ulong? BadConnThreshold{ get; set; }

        /// <summary>
        /// 异常连接检测条件，空连接防护开关，，取值范围[0,1]
        /// </summary>
        [JsonProperty("NullConnEnable")]
        public ulong? NullConnEnable{ get; set; }

        /// <summary>
        /// 异常连接检测条件，连接超时，，取值范围[0,65535]
        /// </summary>
        [JsonProperty("ConnTimeout")]
        public ulong? ConnTimeout{ get; set; }

        /// <summary>
        /// 异常连接检测条件，syn占比ack百分比，，取值范围[0,100]
        /// </summary>
        [JsonProperty("SynRate")]
        public ulong? SynRate{ get; set; }

        /// <summary>
        /// 异常连接检测条件，syn阈值，取值范围[0,100]
        /// </summary>
        [JsonProperty("SynLimit")]
        public ulong? SynLimit{ get; set; }

        /// <summary>
        /// tcp限速，取值范围[0,4294967295]
        /// </summary>
        [JsonProperty("DTcpMbpsLimit")]
        public ulong? DTcpMbpsLimit{ get; set; }

        /// <summary>
        /// udp限速，取值范围[0,4294967295]
        /// </summary>
        [JsonProperty("DUdpMbpsLimit")]
        public ulong? DUdpMbpsLimit{ get; set; }

        /// <summary>
        /// icmp限速，取值范围[0,4294967295]
        /// </summary>
        [JsonProperty("DIcmpMbpsLimit")]
        public ulong? DIcmpMbpsLimit{ get; set; }

        /// <summary>
        /// other协议限速，取值范围[0,4294967295]
        /// </summary>
        [JsonProperty("DOtherMbpsLimit")]
        public ulong? DOtherMbpsLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DropTcp", this.DropTcp);
            this.SetParamSimple(map, prefix + "DropUdp", this.DropUdp);
            this.SetParamSimple(map, prefix + "DropIcmp", this.DropIcmp);
            this.SetParamSimple(map, prefix + "DropOther", this.DropOther);
            this.SetParamSimple(map, prefix + "DropAbroad", this.DropAbroad);
            this.SetParamSimple(map, prefix + "CheckSyncConn", this.CheckSyncConn);
            this.SetParamSimple(map, prefix + "SdNewLimit", this.SdNewLimit);
            this.SetParamSimple(map, prefix + "DstNewLimit", this.DstNewLimit);
            this.SetParamSimple(map, prefix + "SdConnLimit", this.SdConnLimit);
            this.SetParamSimple(map, prefix + "DstConnLimit", this.DstConnLimit);
            this.SetParamSimple(map, prefix + "BadConnThreshold", this.BadConnThreshold);
            this.SetParamSimple(map, prefix + "NullConnEnable", this.NullConnEnable);
            this.SetParamSimple(map, prefix + "ConnTimeout", this.ConnTimeout);
            this.SetParamSimple(map, prefix + "SynRate", this.SynRate);
            this.SetParamSimple(map, prefix + "SynLimit", this.SynLimit);
            this.SetParamSimple(map, prefix + "DTcpMbpsLimit", this.DTcpMbpsLimit);
            this.SetParamSimple(map, prefix + "DUdpMbpsLimit", this.DUdpMbpsLimit);
            this.SetParamSimple(map, prefix + "DIcmpMbpsLimit", this.DIcmpMbpsLimit);
            this.SetParamSimple(map, prefix + "DOtherMbpsLimit", this.DOtherMbpsLimit);
        }
    }
}

