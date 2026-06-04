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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResponseParam : AbstractModel
    {
        
        /// <summary>
        /// 变量描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 参数类型
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 默认值是string，如果不填就按string处理 |
        /// | 1 |  |
        /// | 2 |  |
        /// | 3 |  |
        /// | 4 |  |
        /// | 5 |  |
        /// | 6 |  |
        /// | 7 |  |
        /// | 8 |  |
        /// | 9 |  |
        /// | 20 |  |
        /// | 99 | 空值 |
        /// | 100 | 未指定类型，用于类型为OneOf和AnyOf的场景 |
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 覆盖（全量替换） |
        /// | 1 | 增量追加 |
        /// </summary>
        [JsonProperty("RenderMode")]
        public long? RenderMode{ get; set; }

        /// <summary>
        /// 只对 OBJECT 或 ARRAY_OBJECT 类型有用
        /// </summary>
        [JsonProperty("SubParams")]
        public ResponseParam[] SubParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RenderMode", this.RenderMode);
            this.SetParamArrayObj(map, prefix + "SubParams.", this.SubParams);
        }
    }
}

