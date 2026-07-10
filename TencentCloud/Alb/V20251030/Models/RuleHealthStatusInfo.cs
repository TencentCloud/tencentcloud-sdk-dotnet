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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleHealthStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否为默认转发规则。
        /// </summary>
        [JsonProperty("IsDefaultRule")]
        public string IsDefaultRule{ get; set; }

        /// <summary>
        /// 转发规则 ID，格式为 rule- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 目标组健康状态。
        /// </summary>
        [JsonProperty("TargetGroupHealthInfos")]
        public TargetGroupHealthInfo[] TargetGroupHealthInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsDefaultRule", this.IsDefaultRule);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArrayObj(map, prefix + "TargetGroupHealthInfos.", this.TargetGroupHealthInfos);
        }
    }
}

