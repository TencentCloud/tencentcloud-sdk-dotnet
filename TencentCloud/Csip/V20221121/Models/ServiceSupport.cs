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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceSupport : AbstractModel
    {
        
        /// <summary>
        /// 产品名称:
        /// "cfw_waf_virtual", "cwp_detect", "cwp_defense", "cwp_fix"
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 已处理的资产总数
        /// </summary>
        [JsonProperty("SupportHandledCount")]
        public long? SupportHandledCount{ get; set; }

        /// <summary>
        /// 支持的资产总数
        /// </summary>
        [JsonProperty("SupportTotalCount")]
        public long? SupportTotalCount{ get; set; }

        /// <summary>
        /// 是否支持该产品1支持；0不支持
        /// </summary>
        [JsonProperty("IsSupport")]
        public bool? IsSupport{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "SupportHandledCount", this.SupportHandledCount);
            this.SetParamSimple(map, prefix + "SupportTotalCount", this.SupportTotalCount);
            this.SetParamSimple(map, prefix + "IsSupport", this.IsSupport);
        }
    }
}

