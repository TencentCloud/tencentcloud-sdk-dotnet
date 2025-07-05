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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RateLimitTemplateDetail : AbstractModel
    {
        
        /// <summary>
        /// 模板等级名称，取值有：
        /// <li>sup_loose：超级宽松；</li>
        /// <li>loose：宽松；</li>
        /// <li>emergency：紧急；</li>
        /// <li>normal：适中；</li>
        /// <li>strict：严格；</li>
        /// <li>close：关闭，仅精准速率限制生效。</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 唯一id。
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 模板处置方式，取值有：
        /// <li>alg：JavaScript挑战；</li>
        /// <li>monitor：观察。</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 惩罚时间，取值范围0-2天，单位秒。
        /// </summary>
        [JsonProperty("PunishTime")]
        public long? PunishTime{ get; set; }

        /// <summary>
        /// 统计阈值，单位是次，取值范围0-4294967294。
        /// </summary>
        [JsonProperty("Threshold")]
        public long? Threshold{ get; set; }

        /// <summary>
        /// 统计周期，取值范围0-120秒。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "PunishTime", this.PunishTime);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Period", this.Period);
        }
    }
}

