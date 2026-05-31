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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApmPrometheusRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指标匹配规则名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>规则生效的应用。作用全部应用就传空字符串</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>指标匹配类型：0精准匹配，1前缀匹配，2后缀匹配</p>
        /// </summary>
        [JsonProperty("MetricMatchType")]
        public long? MetricMatchType{ get; set; }

        /// <summary>
        /// <p>客户定义的命中指标名规则。</p>
        /// </summary>
        [JsonProperty("MetricNameRule")]
        public string MetricNameRule{ get; set; }

        /// <summary>
        /// <p>业务系统ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>是否追加资源属性</p>
        /// </summary>
        [JsonProperty("AppendResourceAttributes")]
        public bool? AppendResourceAttributes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "MetricMatchType", this.MetricMatchType);
            this.SetParamSimple(map, prefix + "MetricNameRule", this.MetricNameRule);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AppendResourceAttributes", this.AppendResourceAttributes);
        }
    }
}

