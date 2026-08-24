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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDisasterRecoveryVpcMappingRequest : AbstractModel
    {
        
        /// <summary>
        /// 源端VPC ID
        /// </summary>
        [JsonProperty("SourceVpcId")]
        public string SourceVpcId{ get; set; }

        /// <summary>
        /// 源端子网ID
        /// </summary>
        [JsonProperty("SourceSubnetId")]
        public string SourceSubnetId{ get; set; }

        /// <summary>
        /// 目标端VPC ID
        /// </summary>
        [JsonProperty("TargetVpcId")]
        public string TargetVpcId{ get; set; }

        /// <summary>
        /// 目标端子网ID
        /// </summary>
        [JsonProperty("TargetSubnetId")]
        public string TargetSubnetId{ get; set; }

        /// <summary>
        /// 站点对ID
        /// </summary>
        [JsonProperty("SitePairId")]
        public string SitePairId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceVpcId", this.SourceVpcId);
            this.SetParamSimple(map, prefix + "SourceSubnetId", this.SourceSubnetId);
            this.SetParamSimple(map, prefix + "TargetVpcId", this.TargetVpcId);
            this.SetParamSimple(map, prefix + "TargetSubnetId", this.TargetSubnetId);
            this.SetParamSimple(map, prefix + "SitePairId", this.SitePairId);
        }
    }
}

