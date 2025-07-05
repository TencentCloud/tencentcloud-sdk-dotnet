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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PostPaidEnvDeductInfo : AbstractModel
    {
        
        /// <summary>
        /// 资源方
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 指标名
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 按量计费详情
        /// </summary>
        [JsonProperty("ResQuota")]
        public float? ResQuota{ get; set; }

        /// <summary>
        /// 资源包抵扣详情
        /// </summary>
        [JsonProperty("PkgQuota")]
        public float? PkgQuota{ get; set; }

        /// <summary>
        /// 免费额度抵扣详情
        /// </summary>
        [JsonProperty("FreeQuota")]
        public float? FreeQuota{ get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "ResQuota", this.ResQuota);
            this.SetParamSimple(map, prefix + "PkgQuota", this.PkgQuota);
            this.SetParamSimple(map, prefix + "FreeQuota", this.FreeQuota);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
        }
    }
}

