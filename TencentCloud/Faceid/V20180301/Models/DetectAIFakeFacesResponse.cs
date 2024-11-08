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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectAIFakeFacesResponse : AbstractModel
    {
        
        /// <summary>
        /// 检测到的图片是否存在攻击。
        /// - Low：无攻击风险。
        /// - Mid：中度疑似攻击。
        /// - High：高度疑似攻击。
        /// </summary>
        [JsonProperty("AttackRiskLevel")]
        public string AttackRiskLevel{ get; set; }

        /// <summary>
        /// 检测到疑似的攻击痕迹列表。
        /// - 说明：未检测到攻击痕迹时，返回空数组。
        /// - 此出参仅作为结果判断的参考，实际应用仍建议使用AttackRiskLevel的结果。
        /// </summary>
        [JsonProperty("AttackRiskDetailList")]
        public AttackRiskDetail[] AttackRiskDetailList{ get; set; }

        /// <summary>
        /// 额外信息。
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public ExtraInfo ExtraInfo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttackRiskLevel", this.AttackRiskLevel);
            this.SetParamArrayObj(map, prefix + "AttackRiskDetailList.", this.AttackRiskDetailList);
            this.SetParamObj(map, prefix + "ExtraInfo.", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

