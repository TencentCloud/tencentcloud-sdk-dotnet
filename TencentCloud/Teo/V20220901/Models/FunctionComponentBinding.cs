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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FunctionComponentBinding : AbstractModel
    {
        
        /// <summary>
        /// 绑定的组件类型。取值有：
        /// <li>kv_namespace：KV 命名空间。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 用于绑定的变量名。限制 1-50 个字符，允许的字符为字母、数字和下划线，其中数字不能在开头。在边缘函数代码中通过该变量名访问绑定的组件。根据 Type 的取值不同，使用方式如下：
        /// <li>当 Type 为 kv_namespace 时：在代码中可通过该变量名访问 KV 命名空间，例如设置为 "MY_KV" 时，可通过 MY_KV.get("key") 进行读写操作。</li>
        /// </summary>
        [JsonProperty("VariableName")]
        public string VariableName{ get; set; }

        /// <summary>
        /// KV 命名空间配置参数。用于指定绑定的 KV 命名空间详情。当 Type 为 kv_namespace 时，此字段必填。
        /// 
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KVNamespaceParameters")]
        public KVNamespaceParameters KVNamespaceParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "VariableName", this.VariableName);
            this.SetParamObj(map, prefix + "KVNamespaceParameters.", this.KVNamespaceParameters);
        }
    }
}

