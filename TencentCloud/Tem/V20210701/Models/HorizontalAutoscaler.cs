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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HorizontalAutoscaler : AbstractModel
    {
        
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
        /// 指标度量（CPU or MEMORY）
        /// </summary>
        [JsonProperty("Metrics")]
        public string Metrics{ get; set; }

        /// <summary>
        /// 阈值（百分比）
        /// </summary>
        [JsonProperty("Threshold")]
        public long? Threshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinReplicas", this.MinReplicas);
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamSimple(map, prefix + "Metrics", this.Metrics);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
        }
    }
}

