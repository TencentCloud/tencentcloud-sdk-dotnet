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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWQuotaSubItem : AbstractModel
    {
        
        /// <summary>
        /// <p>子资源 ID（如：模型服务 ID）</p>
        /// </summary>
        [JsonProperty("SubResourceId")]
        public string SubResourceId{ get; set; }

        /// <summary>
        /// <p>该子资源独立配额上限，必须 &gt; 0；单位与 QuotaType 对齐（Cost=元 TotalToken=tokens RequestCount=次）</p>
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public ulong? QuotaLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubResourceId", this.SubResourceId);
            this.SetParamSimple(map, prefix + "QuotaLimit", this.QuotaLimit);
        }
    }
}

