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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubnetInfo : AbstractModel
    {
        
        /// <summary>
        /// vpc id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 应用的集群；可以是集群id,也可以是All
        /// </summary>
        [JsonProperty("UsedCluster")]
        public string UsedCluster{ get; set; }

        /// <summary>
        /// cidr，只有当IsDirectConnect为true时才生效
        /// </summary>
        [JsonProperty("CIDR")]
        public string CIDR{ get; set; }

        /// <summary>
        /// 是否为专线接入场景
        /// </summary>
        [JsonProperty("IsDirectConnect")]
        public bool? IsDirectConnect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "UsedCluster", this.UsedCluster);
            this.SetParamSimple(map, prefix + "CIDR", this.CIDR);
            this.SetParamSimple(map, prefix + "IsDirectConnect", this.IsDirectConnect);
        }
    }
}

