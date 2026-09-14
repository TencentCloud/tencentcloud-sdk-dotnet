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

    public class MetaValue : AbstractModel
    {
        
        /// <summary>
        /// <p>元数据值名称（仅展示使用）</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>是否引用该类型下的全部值（true 时 ref_value_id 应为 0）</p>
        /// </summary>
        [JsonProperty("RefAll")]
        public bool? RefAll{ get; set; }

        /// <summary>
        /// <p>元数据引用的业务 ID（属性 ID、分类 ID 等）；ref_all=true 时该字段应为 0</p>
        /// </summary>
        [JsonProperty("RefValueId")]
        public string RefValueId{ get; set; }

        /// <summary>
        /// <p>元数据使用场景：1=仅检索使用，2=检索和生成都使用<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>META_SCENE_UNKNOWN</td><td>0</td><td>未知</td></tr><tr><td>META_SCENE_SEARCH_ONLY</td><td>1</td><td>仅检索使用</td></tr><tr><td>META_SCENE_ALL</td><td>2</td><td>检索和生成都使用</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("Scene")]
        public long? Scene{ get; set; }

        /// <summary>
        /// <p>元数据值类型：1=属性标签，2=文档分类，3=问答分类<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>META_VALUE_TYPE_UNKNOWN</td><td>0</td><td>未知</td></tr><tr><td>META_VALUE_TYPE_TAG</td><td>1</td><td>属性标签</td></tr><tr><td>META_VALUE_TYPE_DOC_CATEGORY</td><td>2</td><td>文档分类</td></tr><tr><td>META_VALUE_TYPE_QA_CATEGORY</td><td>3</td><td>问答分类</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("ValueType")]
        public long? ValueType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RefAll", this.RefAll);
            this.SetParamSimple(map, prefix + "RefValueId", this.RefValueId);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
        }
    }
}

