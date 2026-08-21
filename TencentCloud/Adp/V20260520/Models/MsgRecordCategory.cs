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

    public class MsgRecordCategory : AbstractModel
    {
        
        /// <summary>
        /// <p>分类的业务 ID</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// <p>子分类列表，树形嵌套</p>
        /// </summary>
        [JsonProperty("Children")]
        public MsgRecordCategory[] Children{ get; set; }

        /// <summary>
        /// <p>分类名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>当前用户对该分类的操作权限</p>
        /// </summary>
        [JsonProperty("Permission")]
        public CategoryPermission Permission{ get; set; }

        /// <summary>
        /// <p>该分类下消息记录的数量</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public string TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamArrayObj(map, prefix + "Children.", this.Children);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Permission.", this.Permission);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}

