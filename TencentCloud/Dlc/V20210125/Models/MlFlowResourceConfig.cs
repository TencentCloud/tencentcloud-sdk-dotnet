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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MlFlowResourceConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>资源 ID（规格模式必填）</p>
        /// </summary>
        [JsonProperty("BillingItem")]
        public string BillingItem{ get; set; }

        /// <summary>
        /// <p>购买份数（规格模式必填，每 Pod 的规格倍数）</p>
        /// </summary>
        [JsonProperty("Spec")]
        public long? Spec{ get; set; }

        /// <summary>
        /// <p>pod CPU 核数（手动模式必填，单 Pod 粒度）</p>
        /// </summary>
        [JsonProperty("PodCpu")]
        public long? PodCpu{ get; set; }

        /// <summary>
        /// <p>pod 内存大小 GB（手动模式必填，单 Pod 粒度）</p>
        /// </summary>
        [JsonProperty("PodMem")]
        public long? PodMem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BillingItem", this.BillingItem);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "PodCpu", this.PodCpu);
            this.SetParamSimple(map, prefix + "PodMem", this.PodMem);
        }
    }
}

