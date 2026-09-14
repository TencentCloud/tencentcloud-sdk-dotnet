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

    public class QAPermission : AbstractModel
    {
        
        /// <summary>
        /// <p>是否可校验（采纳/不采纳）</p>
        /// </summary>
        [JsonProperty("CanAccept")]
        public bool? CanAccept{ get; set; }

        /// <summary>
        /// <p>是否可删除</p>
        /// </summary>
        [JsonProperty("CanDelete")]
        public bool? CanDelete{ get; set; }

        /// <summary>
        /// <p>是否可编辑</p>
        /// </summary>
        [JsonProperty("CanEdit")]
        public bool? CanEdit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanAccept", this.CanAccept);
            this.SetParamSimple(map, prefix + "CanDelete", this.CanDelete);
            this.SetParamSimple(map, prefix + "CanEdit", this.CanEdit);
        }
    }
}

