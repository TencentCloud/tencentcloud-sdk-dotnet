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

namespace TencentCloud.Yunsou.V20191115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchResultItem : AbstractModel
    {
        
        /// <summary>
        /// 动态摘要信息
        /// </summary>
        [JsonProperty("DocAbs")]
        public string DocAbs{ get; set; }

        /// <summary>
        /// 检索文档id
        /// </summary>
        [JsonProperty("DocId")]
        public string DocId{ get; set; }

        /// <summary>
        /// 原始文档信息
        /// </summary>
        [JsonProperty("DocMeta")]
        public string DocMeta{ get; set; }

        /// <summary>
        /// 精计算得分
        /// </summary>
        [JsonProperty("L2Score")]
        public float? L2Score{ get; set; }

        /// <summary>
        /// 文档级回传信息
        /// </summary>
        [JsonProperty("SearchDebuginfo")]
        public string SearchDebuginfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocAbs", this.DocAbs);
            this.SetParamSimple(map, prefix + "DocId", this.DocId);
            this.SetParamSimple(map, prefix + "DocMeta", this.DocMeta);
            this.SetParamSimple(map, prefix + "L2Score", this.L2Score);
            this.SetParamSimple(map, prefix + "SearchDebuginfo", this.SearchDebuginfo);
        }
    }
}

