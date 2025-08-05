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

namespace TencentCloud.Wsa.V20250508.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchProRequest : AbstractModel
    {
        
        /// <summary>
        /// 搜索词
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 返回结果类型，0-自然检索结果(默认)，1-多模态VR结果，2-混合结果（多模态VR结果+自然检索结果）
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 指定域名站内搜索（用于过滤自然检索结果）  注意：  mode=1模式下，参数无效 mode=0模式下对所有结果生效 mode=2模式下对输出的自然结果生效
        /// </summary>
        [JsonProperty("Site")]
        public string Site{ get; set; }

        /// <summary>
        /// 起始时间（用于过滤自然检索结果），精确到秒时间戳格式  注意：  mode=1模式下，参数无效 mode=0模式下对所有结果生效 mode=2模式下对输出的自然结果生效
        /// </summary>
        [JsonProperty("FromTime")]
        public long? FromTime{ get; set; }

        /// <summary>
        /// 结束时间（用于过滤自然检索结果），精确到秒时间戳格式  注意：  mode=1模式下，参数无效 mode=0模式下对所有结果生效 mode=2模式下对输出的自然结果生效
        /// </summary>
        [JsonProperty("ToTime")]
        public long? ToTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Site", this.Site);
            this.SetParamSimple(map, prefix + "FromTime", this.FromTime);
            this.SetParamSimple(map, prefix + "ToTime", this.ToTime);
        }
    }
}

