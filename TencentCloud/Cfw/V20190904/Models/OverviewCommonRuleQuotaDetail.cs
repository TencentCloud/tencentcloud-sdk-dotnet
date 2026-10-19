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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OverviewCommonRuleQuotaDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>允许使用的规则总数。</p>
        /// </summary>
        [JsonProperty("AllowedNum")]
        public long? AllowedNum{ get; set; }

        /// <summary>
        /// <p>已使用规则数量。</p>
        /// </summary>
        [JsonProperty("UsedNum")]
        public long? UsedNum{ get; set; }

        /// <summary>
        /// <p>剩余规则配额数量。</p>
        /// </summary>
        [JsonProperty("RemainQuota")]
        public long? RemainQuota{ get; set; }

        /// <summary>
        /// <p>剩余扩容规则数量。</p>
        /// </summary>
        [JsonProperty("RemainExtensionNum")]
        public long? RemainExtensionNum{ get; set; }

        /// <summary>
        /// <p>入方向规则总数。</p>
        /// </summary>
        [JsonProperty("InTotal")]
        public long? InTotal{ get; set; }

        /// <summary>
        /// <p>入方向启用规则数。</p>
        /// </summary>
        [JsonProperty("InEnableNum")]
        public long? InEnableNum{ get; set; }

        /// <summary>
        /// <p>出方向规则总数。</p>
        /// </summary>
        [JsonProperty("OutTotal")]
        public long? OutTotal{ get; set; }

        /// <summary>
        /// <p>出方向启用规则数。</p>
        /// </summary>
        [JsonProperty("OutEnableNum")]
        public long? OutEnableNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllowedNum", this.AllowedNum);
            this.SetParamSimple(map, prefix + "UsedNum", this.UsedNum);
            this.SetParamSimple(map, prefix + "RemainQuota", this.RemainQuota);
            this.SetParamSimple(map, prefix + "RemainExtensionNum", this.RemainExtensionNum);
            this.SetParamSimple(map, prefix + "InTotal", this.InTotal);
            this.SetParamSimple(map, prefix + "InEnableNum", this.InEnableNum);
            this.SetParamSimple(map, prefix + "OutTotal", this.OutTotal);
            this.SetParamSimple(map, prefix + "OutEnableNum", this.OutEnableNum);
        }
    }
}

