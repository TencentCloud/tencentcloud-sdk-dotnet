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

    public class ExceptionDimensionRow : AbstractModel
    {
        
        /// <summary>
        /// <p>由目录域、维度或TagKey及归一化值确定的稳定、不透明唯一标识。</p>
        /// </summary>
        [JsonProperty("RowKey")]
        public string RowKey{ get; set; }

        /// <summary>
        /// <p>维度显示值；标签保留原始值，普通province/platform/network_type按既有显示别名归一化。</p>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// <p>本行全部 IncludedInTotal=true 主项的 Count 之和，安全非负整数。</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>完整固定分类向量，含0计数及适用包含项；不按数量裁剪。</p>
        /// </summary>
        [JsonProperty("Items")]
        public ExceptionBucket[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RowKey", this.RowKey);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

