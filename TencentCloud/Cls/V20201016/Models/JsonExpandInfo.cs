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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JsonExpandInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启JSON嵌套展开功能。开启后将对指定JSON字段进行扁平化展开处理</p><p>默认值：无（必选参数）</p>
        /// </summary>
        [JsonProperty("Switch")]
        public bool? Switch{ get; set; }

        /// <summary>
        /// <p>待展开的JSON字段名列表，支持1~3个字段，字段名不可为空串且不可重复 </p><p>入参限制：1. 字段数量：1~3个2. 每个字段名长度不超过128个字符3. 字段名不可为空字符串4. 字段名之间不可重复</p><p>默认值：无（必选参数）</p><p>取值参考：取值：message；描述：示例字段名</p><p>示例：[&quot;message&quot;, &quot;data&quot;, &quot;content&quot;]</p>
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// <p>展开后是否丢弃原始的嵌套字段。true: 丢弃原始字段只保留展开后的平铺字段; false: 保留原始字段同时增加展开后的平铺字段</p><p>枚举值：</p><ul><li>true / false： 丢弃原字段 / 保留原字段</li></ul><p>默认值：true</p><p>非必选，不传时默认为true</p>
        /// </summary>
        [JsonProperty("DropOriginal")]
        public bool? DropOriginal{ get; set; }

        /// <summary>
        /// <p>展开后的字段与已有字段发生冲突时的处理策略</p><p>枚举值：</p><ul><li>keep_outer / keep_inner： 保留外层(已存在)字段 / 保留内层(新展开)字段</li></ul><p>默认值：keep_outer</p><p>非必选，不传时默认为keep_outer</p>
        /// </summary>
        [JsonProperty("ConflictPolicy")]
        public string ConflictPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "Fields.", this.Fields);
            this.SetParamSimple(map, prefix + "DropOriginal", this.DropOriginal);
            this.SetParamSimple(map, prefix + "ConflictPolicy", this.ConflictPolicy);
        }
    }
}

