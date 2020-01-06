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

    public class CreateDDoSPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（bgpip表示高防IP；bgp表示独享包；bgp-multip表示共享包；net表示高防IP专业版）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 协议禁用，必须填写且数组长度必须为1
        /// </summary>
        [JsonProperty("DropOptions")]
        public DDoSPolicyDropOption[] DropOptions{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 端口禁用，当没有禁用端口时填空数组
        /// </summary>
        [JsonProperty("PortLimits")]
        public DDoSPolicyPortLimit[] PortLimits{ get; set; }

        /// <summary>
        /// IP黑白名单，当没有IP黑白名单时填空数组
        /// </summary>
        [JsonProperty("IpAllowDenys")]
        public IpBlackWhite[] IpAllowDenys{ get; set; }

        /// <summary>
        /// 报文过滤，当没有报文过滤时填空数组
        /// </summary>
        [JsonProperty("PacketFilters")]
        public DDoSPolicyPacketFilter[] PacketFilters{ get; set; }

        /// <summary>
        /// 水印策略参数，当没有启用水印功能时填空数组，最多只能传一条水印策略（即数组大小不超过1）
        /// </summary>
        [JsonProperty("WaterPrint")]
        public WaterPrintPolicy[] WaterPrint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamArrayObj(map, prefix + "DropOptions.", this.DropOptions);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "PortLimits.", this.PortLimits);
            this.SetParamArrayObj(map, prefix + "IpAllowDenys.", this.IpAllowDenys);
            this.SetParamArrayObj(map, prefix + "PacketFilters.", this.PacketFilters);
            this.SetParamArrayObj(map, prefix + "WaterPrint.", this.WaterPrint);
        }
    }
}

