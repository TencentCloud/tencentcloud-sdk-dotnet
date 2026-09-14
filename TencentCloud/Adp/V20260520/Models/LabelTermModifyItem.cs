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

    public class LabelTermModifyItem : AbstractModel
    {
        
        /// <summary>
        /// <p>操作类型（不可为 0，取值：1=新增，2=修改，3=删除）<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>MODIFY_ACTION_UNKNOWN</td><td>0</td><td></td></tr><tr><td>MODIFY_ACTION_CREATE</td><td>1</td><td>新增</td></tr><tr><td>MODIFY_ACTION_UPDATE</td><td>2</td><td>修改</td></tr><tr><td>MODIFY_ACTION_DELETE</td><td>3</td><td>删除</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("ModifyAction")]
        public long? ModifyAction{ get; set; }

        /// <summary>
        /// <p>同义词列表（CREATE 与 UPDATE 时传完整同义词集合，覆盖式更新）</p>
        /// </summary>
        [JsonProperty("SynonymList")]
        public string[] SynonymList{ get; set; }

        /// <summary>
        /// <p>标准词（CREATE 与 UPDATE 必填，DELETE 可留空）</p>
        /// </summary>
        [JsonProperty("Term")]
        public string Term{ get; set; }

        /// <summary>
        /// <p>标准词 ID（UPDATE 与 DELETE 必填，CREATE 留空由后台生成）</p>
        /// </summary>
        [JsonProperty("TermId")]
        public string TermId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModifyAction", this.ModifyAction);
            this.SetParamArraySimple(map, prefix + "SynonymList.", this.SynonymList);
            this.SetParamSimple(map, prefix + "Term", this.Term);
            this.SetParamSimple(map, prefix + "TermId", this.TermId);
        }
    }
}

