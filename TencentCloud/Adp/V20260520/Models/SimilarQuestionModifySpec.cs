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

    public class SimilarQuestionModifySpec : AbstractModel
    {
        
        /// <summary>
        /// <p>相似问内容（CREATE 与 UPDATE 必填）</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>操作类型：1=新增，2=修改，3=删除<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>MODIFY_ACTION_UNKNOWN</td><td>0</td><td></td></tr><tr><td>MODIFY_ACTION_CREATE</td><td>1</td><td>新增</td></tr><tr><td>MODIFY_ACTION_UPDATE</td><td>2</td><td>修改</td></tr><tr><td>MODIFY_ACTION_DELETE</td><td>3</td><td>删除</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("ModifyAction")]
        public long? ModifyAction{ get; set; }

        /// <summary>
        /// <p>相似问 ID（UPDATE 与 DELETE 必填）</p>
        /// </summary>
        [JsonProperty("SimilarQuestionId")]
        public string SimilarQuestionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ModifyAction", this.ModifyAction);
            this.SetParamSimple(map, prefix + "SimilarQuestionId", this.SimilarQuestionId);
        }
    }
}

