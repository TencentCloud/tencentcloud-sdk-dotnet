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

    public class ModifyKBRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>知识库 ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>可写属性（与 update_mask 配合使用）</p>
        /// </summary>
        [JsonProperty("Spec")]
        public KBSpec Spec{ get; set; }

        /// <summary>
        /// <p>字段掩码：指定要修改的字段（蛇形字段名），未列出的字段忽略</p>
        /// </summary>
        [JsonProperty("UpdateMask")]
        public FieldMask UpdateMask{ get; set; }

        /// <summary>
        /// <p>扩展操作（用于承载无法归类到常规字段修改的特殊操作，例如触发超量恢复等；需在 update_mask 中同时传入 &#39;extend_fields&#39; 才会生效，取值参见 KBExtendedAction：1=触发恢复超量）</p>
        /// </summary>
        [JsonProperty("ExtendFields")]
        public KBModifyExtendFields ExtendFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamObj(map, prefix + "Spec.", this.Spec);
            this.SetParamObj(map, prefix + "UpdateMask.", this.UpdateMask);
            this.SetParamObj(map, prefix + "ExtendFields.", this.ExtendFields);
        }
    }
}

