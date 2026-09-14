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

    public class ModifyConflictQARequest : AbstractModel
    {
        
        /// <summary>
        /// <p>所属知识库 ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>冲突组 ID（全局忽略时可不传）</p>
        /// </summary>
        [JsonProperty("ConflictGroupId")]
        public string ConflictGroupId{ get; set; }

        /// <summary>
        /// <p>是否全局忽略（忽略当前KB下所有待处理冲突问）</p>
        /// </summary>
        [JsonProperty("IsIgnoreAll")]
        public bool? IsIgnoreAll{ get; set; }

        /// <summary>
        /// <p>决策涉及的 QA ID 列表（KEEP 与 DELETE 必填）</p>
        /// </summary>
        [JsonProperty("QaIdList")]
        public string[] QaIdList{ get; set; }

        /// <summary>
        /// <p>冲突解决策略：1=保留，2=忽略，3=删除（全局忽略时可不传）<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>CONFLICT_RESOLUTION_UNKNOWN</td><td>0</td><td></td></tr><tr><td>CONFLICT_RESOLUTION_KEEP</td><td>1</td><td>保留</td></tr><tr><td>CONFLICT_RESOLUTION_IGNORE</td><td>2</td><td>忽略</td></tr><tr><td>CONFLICT_RESOLUTION_DELETE</td><td>3</td><td>删除</td></tr><tr><td>CONFLICT_RESOLUTION_MERGE</td><td>4</td><td>合并</td></tr><tr><td>CONFLICT_RESOLUTION_REPLACE</td><td>5</td><td>替换</td></tr><tr><td>CONFLICT_RESOLUTION_RENAME</td><td>6</td><td>重命名</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("Resolution")]
        public long? Resolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "ConflictGroupId", this.ConflictGroupId);
            this.SetParamSimple(map, prefix + "IsIgnoreAll", this.IsIgnoreAll);
            this.SetParamArraySimple(map, prefix + "QaIdList.", this.QaIdList);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
        }
    }
}

