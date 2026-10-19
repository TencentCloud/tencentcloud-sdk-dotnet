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

    public class OverviewResourceQuotaDataLite : AbstractModel
    {
        
        /// <summary>
        /// <p>资源与配额详情核心数据，包含南北向带宽、东西向带宽、NDR 带宽、资源配额和日志存储信息。</p>
        /// </summary>
        [JsonProperty("Detail")]
        public OverviewResourceQuotaDetail Detail{ get; set; }

        /// <summary>
        /// <p>纯按量计费使用情况</p>
        /// </summary>
        [JsonProperty("VolumeUsageDetail")]
        public VolumeUsageDetail VolumeUsageDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Detail.", this.Detail);
            this.SetParamObj(map, prefix + "VolumeUsageDetail.", this.VolumeUsageDetail);
        }
    }
}

