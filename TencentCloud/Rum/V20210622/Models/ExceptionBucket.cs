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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExceptionBucket : AbstractModel
    {
        
        /// <summary>
        /// <p>固定目录分类 key，与请求平台、CategoryKeys 或 EventTypes 派生目录一致。</p>
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>精确事件行数，0至9007199254740991的整数，0必须保留。</p>
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>是否为计入 TotalCount 的互斥主项。包含项为false，不重复计总。</p>
        /// </summary>
        [JsonProperty("IncludedInTotal")]
        public bool? IncludedInTotal{ get; set; }

        /// <summary>
        /// <p>包含项所属主项的 Key；主项不返回该字段。</p>
        /// </summary>
        [JsonProperty("ParentKey")]
        public string ParentKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "IncludedInTotal", this.IncludedInTotal);
            this.SetParamSimple(map, prefix + "ParentKey", this.ParentKey);
        }
    }
}

