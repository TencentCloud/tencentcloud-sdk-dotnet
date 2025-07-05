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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GeneralResourceQuota : AbstractModel
    {
        
        /// <summary>
        /// 资源名称。
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 资源当前可用数量。
        /// </summary>
        [JsonProperty("ResourceQuotaAvailable")]
        public long? ResourceQuotaAvailable{ get; set; }

        /// <summary>
        /// 资源总数量。
        /// </summary>
        [JsonProperty("ResourceQuotaTotal")]
        public long? ResourceQuotaTotal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ResourceQuotaAvailable", this.ResourceQuotaAvailable);
            this.SetParamSimple(map, prefix + "ResourceQuotaTotal", this.ResourceQuotaTotal);
        }
    }
}

