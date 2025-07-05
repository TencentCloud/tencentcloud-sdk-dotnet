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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IdentityPolicy : AbstractModel
    {
        
        /// <summary>
        /// CAM预设策略ID。PolicyType 为预设策略时有效且必选
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// CAM预设策略名称。PolicyType 为预设策略时有效且必选
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 策略类型。取值 1-自定义策略  2-预设策略；默认值2
        /// </summary>
        [JsonProperty("PolicyType")]
        public ulong? PolicyType{ get; set; }

        /// <summary>
        /// 自定义策略内容，遵循CAM策略语法。PolicyType 为自定义策略时有效且必选
        /// </summary>
        [JsonProperty("PolicyDocument")]
        public string PolicyDocument{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyDocument", this.PolicyDocument);
        }
    }
}

