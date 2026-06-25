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

    public class ItemNames : AbstractModel
    {
        
        /// <summary>
        /// <p>自定义抽取功能需返回的字段名称。</p>
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// <p>默认 0；0表示kv对  1表示 表格字段。</p>
        /// </summary>
        [JsonProperty("KeyType")]
        public long? KeyType{ get; set; }

        /// <summary>
        /// <p>抽取字段的描述内容。</p>
        /// </summary>
        [JsonProperty("KeyPrompt")]
        public string KeyPrompt{ get; set; }

        /// <summary>
        /// <p>自定义字段对应期望的值内容（这个一般需要对字段审核比对才需要输入）。</p>
        /// </summary>
        [JsonProperty("KeyExpectedValue")]
        public string KeyExpectedValue{ get; set; }

        /// <summary>
        /// <p>自定义字段审核比对的规则prompt。</p><p>比如keyname是姓名，KeyExpectedValue 张三，KeyAuditPrompt设置为“字符需要完全匹配则审核返回正确”/“字符匹配90%就审核返回正确”</p>
        /// </summary>
        [JsonProperty("KeyAuditPrompt")]
        public string KeyAuditPrompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "KeyType", this.KeyType);
            this.SetParamSimple(map, prefix + "KeyPrompt", this.KeyPrompt);
            this.SetParamSimple(map, prefix + "KeyExpectedValue", this.KeyExpectedValue);
            this.SetParamSimple(map, prefix + "KeyAuditPrompt", this.KeyAuditPrompt);
        }
    }
}

