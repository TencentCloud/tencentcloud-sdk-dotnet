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

    public class VpcViewInfo : AbstractModel
    {
        
        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 私有网络CIDR
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 私有网络所在可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 外网负载均衡个数
        /// </summary>
        [JsonProperty("LbNum")]
        public ulong? LbNum{ get; set; }

        /// <summary>
        /// 弹性公网IP个数
        /// </summary>
        [JsonProperty("EipNum")]
        public ulong? EipNum{ get; set; }

        /// <summary>
        /// NAT网关个数
        /// </summary>
        [JsonProperty("NatNum")]
        public ulong? NatNum{ get; set; }

        /// <summary>
        /// 子网列表
        /// </summary>
        [JsonProperty("SubnetSet")]
        public VpcSubnetViewInfo[] SubnetSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "LbNum", this.LbNum);
            this.SetParamSimple(map, prefix + "EipNum", this.EipNum);
            this.SetParamSimple(map, prefix + "NatNum", this.NatNum);
            this.SetParamArrayObj(map, prefix + "SubnetSet.", this.SubnetSet);
        }
    }
}

