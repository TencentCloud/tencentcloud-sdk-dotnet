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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GeneralCardWarnInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否存在该告警
        /// </summary>
        [JsonProperty("IsWarn")]
        public bool? IsWarn{ get; set; }

        /// <summary>
        /// 风险程度
        /// </summary>
        [JsonProperty("RiskConfidence")]
        public float? RiskConfidence{ get; set; }

        /// <summary>
        /// 告警位置四点坐标
        /// </summary>
        [JsonProperty("Polygon")]
        public Polygon[] Polygon{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsWarn", this.IsWarn);
            this.SetParamSimple(map, prefix + "RiskConfidence", this.RiskConfidence);
            this.SetParamArrayObj(map, prefix + "Polygon.", this.Polygon);
        }
    }
}

