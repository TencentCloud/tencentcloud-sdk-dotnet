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

    public class ModifyDDoSPolicyCaseRequest : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（bgpip表示高防IP；bgp表示独享包；bgp-multip表示共享包；net表示高防IP专业版）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 策略场景ID
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// 开发平台，取值[PC（PC客户端）， MOBILE（移动端）， TV（电视端）， SERVER（主机）]
        /// </summary>
        [JsonProperty("PlatformTypes")]
        public string[] PlatformTypes{ get; set; }

        /// <summary>
        /// 细分品类，取值[WEB（网站）， GAME（游戏）， APP（应用）， OTHER（其他）]
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// 应用协议，取值[tcp（TCP协议），udp（UDP协议），icmp（ICMP协议），all（其他协议）]
        /// </summary>
        [JsonProperty("AppProtocols")]
        public string[] AppProtocols{ get; set; }

        /// <summary>
        /// TCP业务起始端口，取值(0, 65535]
        /// </summary>
        [JsonProperty("TcpSportStart")]
        public string TcpSportStart{ get; set; }

        /// <summary>
        /// TCP业务结束端口，取值(0, 65535]，必须大于等于TCP业务起始端口
        /// </summary>
        [JsonProperty("TcpSportEnd")]
        public string TcpSportEnd{ get; set; }

        /// <summary>
        /// UDP业务起始端口，取值范围(0, 65535]
        /// </summary>
        [JsonProperty("UdpSportStart")]
        public string UdpSportStart{ get; set; }

        /// <summary>
        /// UDP业务结束端口，取值范围(0, 65535)，必须大于等于UDP业务起始端口
        /// </summary>
        [JsonProperty("UdpSportEnd")]
        public string UdpSportEnd{ get; set; }

        /// <summary>
        /// 是否有海外客户，取值[no（没有）, yes（有）]
        /// </summary>
        [JsonProperty("HasAbroad")]
        public string HasAbroad{ get; set; }

        /// <summary>
        /// 是否会主动对外发起TCP请求，取值[no（不会）, yes（会）]
        /// </summary>
        [JsonProperty("HasInitiateTcp")]
        public string HasInitiateTcp{ get; set; }

        /// <summary>
        /// 是否会主动对外发起UDP业务请求，取值[no（不会）, yes（会）]
        /// </summary>
        [JsonProperty("HasInitiateUdp")]
        public string HasInitiateUdp{ get; set; }

        /// <summary>
        /// 主动发起TCP请求的端口，取值范围(0, 65535]
        /// </summary>
        [JsonProperty("PeerTcpPort")]
        public string PeerTcpPort{ get; set; }

        /// <summary>
        /// 主动发起UDP请求的端口，取值范围(0, 65535]
        /// </summary>
        [JsonProperty("PeerUdpPort")]
        public string PeerUdpPort{ get; set; }

        /// <summary>
        /// TCP载荷的固定特征码，字符串长度小于512
        /// </summary>
        [JsonProperty("TcpFootprint")]
        public string TcpFootprint{ get; set; }

        /// <summary>
        /// UDP载荷的固定特征码，字符串长度小于512
        /// </summary>
        [JsonProperty("UdpFootprint")]
        public string UdpFootprint{ get; set; }

        /// <summary>
        /// Web业务的API的URL
        /// </summary>
        [JsonProperty("WebApiUrl")]
        public string[] WebApiUrl{ get; set; }

        /// <summary>
        /// TCP业务报文长度最小值，取值范围(0, 1500)
        /// </summary>
        [JsonProperty("MinTcpPackageLen")]
        public string MinTcpPackageLen{ get; set; }

        /// <summary>
        /// TCP业务报文长度最大值，取值范围(0, 1500)，必须大于等于TCP业务报文长度最小值
        /// </summary>
        [JsonProperty("MaxTcpPackageLen")]
        public string MaxTcpPackageLen{ get; set; }

        /// <summary>
        /// UDP业务报文长度最小值，取值范围(0, 1500)
        /// </summary>
        [JsonProperty("MinUdpPackageLen")]
        public string MinUdpPackageLen{ get; set; }

        /// <summary>
        /// UDP业务报文长度最大值，取值范围(0, 1500)，必须大于等于UDP业务报文长度最小值
        /// </summary>
        [JsonProperty("MaxUdpPackageLen")]
        public string MaxUdpPackageLen{ get; set; }

        /// <summary>
        /// 是否有VPN业务，取值[no（没有）, yes（有）]
        /// </summary>
        [JsonProperty("HasVPN")]
        public string HasVPN{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamArraySimple(map, prefix + "PlatformTypes.", this.PlatformTypes);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamArraySimple(map, prefix + "AppProtocols.", this.AppProtocols);
            this.SetParamSimple(map, prefix + "TcpSportStart", this.TcpSportStart);
            this.SetParamSimple(map, prefix + "TcpSportEnd", this.TcpSportEnd);
            this.SetParamSimple(map, prefix + "UdpSportStart", this.UdpSportStart);
            this.SetParamSimple(map, prefix + "UdpSportEnd", this.UdpSportEnd);
            this.SetParamSimple(map, prefix + "HasAbroad", this.HasAbroad);
            this.SetParamSimple(map, prefix + "HasInitiateTcp", this.HasInitiateTcp);
            this.SetParamSimple(map, prefix + "HasInitiateUdp", this.HasInitiateUdp);
            this.SetParamSimple(map, prefix + "PeerTcpPort", this.PeerTcpPort);
            this.SetParamSimple(map, prefix + "PeerUdpPort", this.PeerUdpPort);
            this.SetParamSimple(map, prefix + "TcpFootprint", this.TcpFootprint);
            this.SetParamSimple(map, prefix + "UdpFootprint", this.UdpFootprint);
            this.SetParamArraySimple(map, prefix + "WebApiUrl.", this.WebApiUrl);
            this.SetParamSimple(map, prefix + "MinTcpPackageLen", this.MinTcpPackageLen);
            this.SetParamSimple(map, prefix + "MaxTcpPackageLen", this.MaxTcpPackageLen);
            this.SetParamSimple(map, prefix + "MinUdpPackageLen", this.MinUdpPackageLen);
            this.SetParamSimple(map, prefix + "MaxUdpPackageLen", this.MaxUdpPackageLen);
            this.SetParamSimple(map, prefix + "HasVPN", this.HasVPN);
        }
    }
}

