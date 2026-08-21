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

    public class CategoryPermission : AbstractModel
    {
        
        /// <summary>
        /// <p>当前用户是否可新增子分类</p>
        /// </summary>
        [JsonProperty("CanAdd")]
        public bool? CanAdd{ get; set; }

        /// <summary>
        /// <p>当前用户是否可删除该分类</p>
        /// </summary>
        [JsonProperty("CanDelete")]
        public bool? CanDelete{ get; set; }

        /// <summary>
        /// <p>当前用户是否可编辑该分类</p>
        /// </summary>
        [JsonProperty("CanEdit")]
        public bool? CanEdit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanAdd", this.CanAdd);
            this.SetParamSimple(map, prefix + "CanDelete", this.CanDelete);
            this.SetParamSimple(map, prefix + "CanEdit", this.CanEdit);
        }
    }
}

