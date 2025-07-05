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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricSpec : AbstractModel
    {
        
        /// <summary>
        /// 指标来源类型，支持 Pods/Resource
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 使用自定义指标扩进行自动扩缩容
        /// </summary>
        [JsonProperty("Pods")]
        public PodsMetricSource Pods{ get; set; }

        /// <summary>
        /// 使用资源指标扩进行自动扩缩容
        /// </summary>
        [JsonProperty("Resource")]
        public ResourceMetricSource Resource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Pods.", this.Pods);
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
        }
    }
}

