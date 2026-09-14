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

    public class DeDuplicateStrategy : AbstractModel
    {
        
        /// <summary>
        /// <p>校验方式：1=按文档内容判断是否相同<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>DUPLICATE_FILE_CHECK_TYPE_UNKNOWN</td><td>0</td><td>未知</td></tr><tr><td>DUPLICATE_FILE_CHECK_TYPE_COS_HASH</td><td>1</td><td>按文档内容（cos_hash）判断是否相同</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("CheckType")]
        public long? CheckType{ get; set; }

        /// <summary>
        /// <p>处理方式：1=返回报错，2=跳过并返回重复的文档 ID<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>DUPLICATE_FILE_HANDLE_TYPE_UNKNOWN</td><td>0</td><td>未知</td></tr><tr><td>DUPLICATE_FILE_HANDLE_TYPE_RETURN_ERR</td><td>1</td><td>返回报错</td></tr><tr><td>DUPLICATE_FILE_HANDLE_TYPE_SKIP</td><td>2</td><td>跳过，返回重复的文档 ID</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("HandleType")]
        public long? HandleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "HandleType", this.HandleType);
        }
    }
}

