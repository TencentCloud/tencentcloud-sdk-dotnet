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

    public class SecurityGroupMapping : AbstractModel
    {
        
        /// <summary>
        /// 安全组映射ID
        /// </summary>
        [JsonProperty("SecurityGroupMappingId")]
        public string SecurityGroupMappingId{ get; set; }

        /// <summary>
        /// 安全组映射所属的站点对ID
        /// </summary>
        [JsonProperty("SitePairId")]
        public string SitePairId{ get; set; }

        /// <summary>
        /// 生产端安全组ID
        /// </summary>
        [JsonProperty("SourceSecurityGroupId")]
        public string SourceSecurityGroupId{ get; set; }

        /// <summary>
        /// 容灾端安全组ID
        /// </summary>
        [JsonProperty("TargetSecurityGroupId")]
        public string TargetSecurityGroupId{ get; set; }

        /// <summary>
        /// 安全组映射的生命状态；NORMAL:正常。
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityGroupMappingId", this.SecurityGroupMappingId);
            this.SetParamSimple(map, prefix + "SitePairId", this.SitePairId);
            this.SetParamSimple(map, prefix + "SourceSecurityGroupId", this.SourceSecurityGroupId);
            this.SetParamSimple(map, prefix + "TargetSecurityGroupId", this.TargetSecurityGroupId);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
        }
    }
}

