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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HorizontalPodAutoscaler : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 最小实例数
        /// </summary>
        [JsonProperty("MinReplicas")]
        public long? MinReplicas{ get; set; }

        /// <summary>
        /// 最大实例数
        /// </summary>
        [JsonProperty("MaxReplicas")]
        public long? MaxReplicas{ get; set; }

        /// <summary>
        /// 资源目标指标
        /// </summary>
        [JsonProperty("ResourceMetricTarget")]
        public ResourceMetricTarget[] ResourceMetricTarget{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "MinReplicas", this.MinReplicas);
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamArrayObj(map, prefix + "ResourceMetricTarget.", this.ResourceMetricTarget);
        }
    }
}

