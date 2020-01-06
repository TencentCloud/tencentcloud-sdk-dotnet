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

namespace TencentCloud.Bmvpc.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySubnetDHCPRelayRequest : AbstractModel
    {
        
        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 是否开启DHCP Relay
        /// </summary>
        [JsonProperty("EnableDHCP")]
        public bool? EnableDHCP{ get; set; }

        /// <summary>
        /// DHCP服务器IP
        /// </summary>
        [JsonProperty("ServerIps")]
        public string[] ServerIps{ get; set; }

        /// <summary>
        /// 预留IP个数
        /// </summary>
        [JsonProperty("ReservedIpCount")]
        public ulong? ReservedIpCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "EnableDHCP", this.EnableDHCP);
            this.SetParamArraySimple(map, prefix + "ServerIps.", this.ServerIps);
            this.SetParamSimple(map, prefix + "ReservedIpCount", this.ReservedIpCount);
        }
    }
}

