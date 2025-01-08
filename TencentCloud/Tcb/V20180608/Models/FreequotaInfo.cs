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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FreequotaInfo : AbstractModel
    {
        
        /// <summary>
        /// 资源类型
        /// <li>COS</li>
        /// <li>CDN</li>
        /// <li>FLEXDB</li>
        /// <li>SCF</li>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 资源指标名称
        /// </summary>
        [JsonProperty("ResourceMetric")]
        public string ResourceMetric{ get; set; }

        /// <summary>
        /// 资源指标免费量
        /// </summary>
        [JsonProperty("FreeQuota")]
        public long? FreeQuota{ get; set; }

        /// <summary>
        /// 指标单位
        /// </summary>
        [JsonProperty("MetricUnit")]
        public string MetricUnit{ get; set; }

        /// <summary>
        /// 免费量抵扣周期
        /// <li>sum-month:以月为单位抵扣</li>
        /// <li>sum-day:以天为单位抵扣</li>
        /// <li>totalize:总容量抵扣</li>
        /// </summary>
        [JsonProperty("DeductType")]
        public string DeductType{ get; set; }

        /// <summary>
        /// 免费量类型
        /// <li>basic:通用量抵扣</li>
        /// </summary>
        [JsonProperty("FreeQuotaType")]
        public string FreeQuotaType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceMetric", this.ResourceMetric);
            this.SetParamSimple(map, prefix + "FreeQuota", this.FreeQuota);
            this.SetParamSimple(map, prefix + "MetricUnit", this.MetricUnit);
            this.SetParamSimple(map, prefix + "DeductType", this.DeductType);
            this.SetParamSimple(map, prefix + "FreeQuotaType", this.FreeQuotaType);
        }
    }
}

