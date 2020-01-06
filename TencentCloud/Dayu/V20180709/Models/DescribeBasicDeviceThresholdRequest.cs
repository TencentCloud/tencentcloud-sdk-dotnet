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

    public class DescribeBasicDeviceThresholdRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询的IP地址，取值如：1.1.1.1
        /// </summary>
        [JsonProperty("BasicIp")]
        public string BasicIp{ get; set; }

        /// <summary>
        /// 查询IP所属地域，取值如：gz、bj、sh、hk等地域缩写
        /// </summary>
        [JsonProperty("BasicRegion")]
        public string BasicRegion{ get; set; }

        /// <summary>
        /// 专区类型，取值如：公有云专区：public，黑石专区：bm, NAT服务器专区：nat，互联网通道：channel。
        /// </summary>
        [JsonProperty("BasicBizType")]
        public string BasicBizType{ get; set; }

        /// <summary>
        /// 设备类型，取值如：服务器：cvm，公有云负载均衡：clb，黑石负载均衡：lb，NAT服务器：nat，互联网通道：channel.
        /// </summary>
        [JsonProperty("BasicDeviceType")]
        public string BasicDeviceType{ get; set; }

        /// <summary>
        /// 有效性检查，取值为1
        /// </summary>
        [JsonProperty("BasicCheckFlag")]
        public ulong? BasicCheckFlag{ get; set; }

        /// <summary>
        /// 可选，IPInstance Nat 网关（如果查询的设备类型是NAT服务器，需要传此参数，通过nat资源查询接口获取）
        /// </summary>
        [JsonProperty("BasicIpInstance")]
        public string BasicIpInstance{ get; set; }

        /// <summary>
        /// 可选，运营商线路（如果查询的设备类型是NAT服务器，需要传此参数为5）
        /// </summary>
        [JsonProperty("BasicIspCode")]
        public ulong? BasicIspCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BasicIp", this.BasicIp);
            this.SetParamSimple(map, prefix + "BasicRegion", this.BasicRegion);
            this.SetParamSimple(map, prefix + "BasicBizType", this.BasicBizType);
            this.SetParamSimple(map, prefix + "BasicDeviceType", this.BasicDeviceType);
            this.SetParamSimple(map, prefix + "BasicCheckFlag", this.BasicCheckFlag);
            this.SetParamSimple(map, prefix + "BasicIpInstance", this.BasicIpInstance);
            this.SetParamSimple(map, prefix + "BasicIspCode", this.BasicIspCode);
        }
    }
}

