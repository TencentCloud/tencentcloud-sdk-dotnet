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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>查询场景。例如：查询航班、查询库存等。</p>
        /// </summary>
        [JsonProperty("SearchScene")]
        public string SearchScene{ get; set; }

        /// <summary>
        /// <p>查询参数。查询时输入的参数。</p>
        /// </summary>
        [JsonProperty("SearchParam")]
        public string SearchParam{ get; set; }

        /// <summary>
        /// <p>上一个网页URL</p>
        /// </summary>
        [JsonProperty("ReferPageUrl")]
        public string ReferPageUrl{ get; set; }

        /// <summary>
        /// <p>游客账号ID</p>
        /// </summary>
        [JsonProperty("GuestId")]
        public string GuestId{ get; set; }

        /// <summary>
        /// <p>与RCE-PRO约定的定制化信息。为K:V 格式的对象数组。<br>示例：[{&quot;Key&quot;: &quot;ApproverName&quot;, &quot;Value&quot;: &quot;bob&quot;},{&quot;Key&quot;:&quot;ApproverPhone&quot;,&quot;Value&quot;: &quot;+86131****5678&quot;}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SearchScene", this.SearchScene);
            this.SetParamSimple(map, prefix + "SearchParam", this.SearchParam);
            this.SetParamSimple(map, prefix + "ReferPageUrl", this.ReferPageUrl);
            this.SetParamSimple(map, prefix + "GuestId", this.GuestId);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

