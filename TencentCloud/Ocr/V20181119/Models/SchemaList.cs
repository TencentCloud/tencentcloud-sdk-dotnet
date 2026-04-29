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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SchemaList : AbstractModel
    {
        
        /// <summary>
        /// <p>自定义需提取的字段名称。注：若需提取多个字段，可定义多个KeyName。</p>
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// <p>字段类型。</p><p>枚举值：</p><ul><li>0： 表示KeyName为简单字段（如姓名、性别等）。</li><li>1： 表示KeyName为数组对象（如工作经历、教育经历列表）。</li></ul>
        /// </summary>
        [JsonProperty("KeyType")]
        public long? KeyType{ get; set; }

        /// <summary>
        /// <p>补充提取字段的描述。</p>
        /// </summary>
        [JsonProperty("KeyPrompt")]
        public string KeyPrompt{ get; set; }

        /// <summary>
        /// <p>嵌套SchemaList结构，最多支持嵌套三层。注：仅当KeyType=1时生效。</p>
        /// </summary>
        [JsonProperty("SubItems")]
        public SchemaList[] SubItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "KeyType", this.KeyType);
            this.SetParamSimple(map, prefix + "KeyPrompt", this.KeyPrompt);
            this.SetParamArrayObj(map, prefix + "SubItems.", this.SubItems);
        }
    }
}

