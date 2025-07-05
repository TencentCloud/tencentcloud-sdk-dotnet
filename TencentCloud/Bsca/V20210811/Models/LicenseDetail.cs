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

namespace TencentCloud.Bsca.V20210811.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LicenseDetail : AbstractModel
    {
        
        /// <summary>
        /// 许可证内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 许可证允许信息列表
        /// </summary>
        [JsonProperty("ConditionSet")]
        public LicenseRestriction[] ConditionSet{ get; set; }

        /// <summary>
        /// 许可证要求信息列表
        /// </summary>
        [JsonProperty("ForbiddenSet")]
        public LicenseRestriction[] ForbiddenSet{ get; set; }

        /// <summary>
        /// 许可证禁止信息列表
        /// </summary>
        [JsonProperty("PermissionSet")]
        public LicenseRestriction[] PermissionSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArrayObj(map, prefix + "ConditionSet.", this.ConditionSet);
            this.SetParamArrayObj(map, prefix + "ForbiddenSet.", this.ForbiddenSet);
            this.SetParamArrayObj(map, prefix + "PermissionSet.", this.PermissionSet);
        }
    }
}

