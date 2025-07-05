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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunReRankRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询内容，必填
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 文档列表，必填，最多20个
        /// </summary>
        [JsonProperty("Docs")]
        public string[] Docs{ get; set; }

        /// <summary>
        /// 模型名称, 非必填，默认: lke-reranker-base
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 需要计算关联性的2段内容
        /// </summary>
        [JsonProperty("DataList")]
        [System.Obsolete]
        public ReRankDataObject[] DataList{ get; set; }

        /// <summary>
        /// 是否在线, 后台异步任务使用离线, 实时任务使用在线, 默认值: false
        /// </summary>
        [JsonProperty("Online")]
        [System.Obsolete]
        public bool? Online{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamArraySimple(map, prefix + "Docs.", this.Docs);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "DataList.", this.DataList);
            this.SetParamSimple(map, prefix + "Online", this.Online);
        }
    }
}

