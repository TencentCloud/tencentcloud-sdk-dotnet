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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SSAIUsageInfo : AbstractModel
    {
        
        /// <summary>
        /// 广告请求成功次数
        /// </summary>
        [JsonProperty("AdRequestSuccess")]
        public ulong? AdRequestSuccess{ get; set; }

        /// <summary>
        /// 广告请求失败次数
        /// </summary>
        [JsonProperty("AdRequestFail")]
        public ulong? AdRequestFail{ get; set; }

        /// <summary>
        /// 曝光次数
        /// </summary>
        [JsonProperty("Impression")]
        public ulong? Impression{ get; set; }

        /// <summary>
        /// 中贴个性化广告填充率
        /// </summary>
        [JsonProperty("MidFillRate")]
        public float? MidFillRate{ get; set; }

        /// <summary>
        /// 中贴广告标记时间
        /// </summary>
        [JsonProperty("AdMarkerTime")]
        public float? AdMarkerTime{ get; set; }

        /// <summary>
        /// 中贴个性化替换时间
        /// </summary>
        [JsonProperty("ReplacedTime")]
        public float? ReplacedTime{ get; set; }

        /// <summary>
        /// 前贴广告替换率
        /// </summary>
        [JsonProperty("PreReplaceRate")]
        public float? PreReplaceRate{ get; set; }

        /// <summary>
        /// 前贴广告请求数
        /// </summary>
        [JsonProperty("PreReqNum")]
        public ulong? PreReqNum{ get; set; }

        /// <summary>
        /// 前贴广告替换数
        /// </summary>
        [JsonProperty("PreReplacedNum")]
        public ulong? PreReplacedNum{ get; set; }

        /// <summary>
        /// 各广告配置用量详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsageDetails")]
        public UsageDetail[] UsageDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AdRequestSuccess", this.AdRequestSuccess);
            this.SetParamSimple(map, prefix + "AdRequestFail", this.AdRequestFail);
            this.SetParamSimple(map, prefix + "Impression", this.Impression);
            this.SetParamSimple(map, prefix + "MidFillRate", this.MidFillRate);
            this.SetParamSimple(map, prefix + "AdMarkerTime", this.AdMarkerTime);
            this.SetParamSimple(map, prefix + "ReplacedTime", this.ReplacedTime);
            this.SetParamSimple(map, prefix + "PreReplaceRate", this.PreReplaceRate);
            this.SetParamSimple(map, prefix + "PreReqNum", this.PreReqNum);
            this.SetParamSimple(map, prefix + "PreReplacedNum", this.PreReplacedNum);
            this.SetParamArrayObj(map, prefix + "UsageDetails.", this.UsageDetails);
        }
    }
}

