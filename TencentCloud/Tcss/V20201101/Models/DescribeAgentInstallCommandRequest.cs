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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAgentInstallCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否是腾讯云
        /// </summary>
        [JsonProperty("IsCloud")]
        public bool? IsCloud{ get; set; }

        /// <summary>
        /// 网络类型：basic-基础网络，private-VPC, public-公网，direct-专线
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// 地域标示, NetType=direct时必填
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// VpcId, NetType=direct时必填
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 命令有效期，非腾讯云时必填
        /// </summary>
        [JsonProperty("ExpireDate")]
        public string ExpireDate{ get; set; }

        /// <summary>
        /// 标签ID列表，IsCloud=false时才会生效
        /// </summary>
        [JsonProperty("TagIds")]
        public ulong?[] TagIds{ get; set; }

        /// <summary>
        /// 虚拟ip
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsCloud", this.IsCloud);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "ExpireDate", this.ExpireDate);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
        }
    }
}

