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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchOperateUserSignatureRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 0:关闭，1:开启，2:仅观察
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 如果SelectedAll为true，则表示反选的规则，否则表示手动选择的规则ID
        /// </summary>
        [JsonProperty("RuleIds")]
        public string[] RuleIds{ get; set; }

        /// <summary>
        /// 仅观察原因
        /// </summary>
        [JsonProperty("Reason")]
        public long? Reason{ get; set; }

        /// <summary>
        /// 是否全选
        /// </summary>
        [JsonProperty("SelectedAll")]
        public bool? SelectedAll{ get; set; }

        /// <summary>
        /// 过滤
        /// </summary>
        [JsonProperty("Filters")]
        public FiltersItemNew[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "RuleIds.", this.RuleIds);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "SelectedAll", this.SelectedAll);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

