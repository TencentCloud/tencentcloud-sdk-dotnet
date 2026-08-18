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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PlatformUsageSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>PLATFORM 域消耗计量列表（权威字段）：按单位+label 分项列出每类计量，label 取 PlatformBizType 枚举名称字符串；典型如 unit=TIMES + label=PLATFORM_BIZ_TYPE_SECURITY_AUDIT/WEB_SEARCH/OPEN_CLAW/APP_INVOKE，unit=ITEM + label=PLATFORM_BIZ_TYPE_LONG_TERM_MEMORY</p>
        /// </summary>
        [JsonProperty("ResourceConsumptionList")]
        public ResourceConsumption[] ResourceConsumptionList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ResourceConsumptionList.", this.ResourceConsumptionList);
        }
    }
}

