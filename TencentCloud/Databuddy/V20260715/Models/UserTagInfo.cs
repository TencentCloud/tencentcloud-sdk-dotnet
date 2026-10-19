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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserTagInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>标签维度ID。ID 模式写接口（UpdateWorkspaceUsersTags / UpdateWorkspaceGroupsTags）中必填，可通过 ListTags 接口出参 Items[].TagId 获取，也可通过 CreateTags 创建后获取；按名称模式接口（AttachWorkspaceUserTags / DetachWorkspaceUserTags）中无需传入；查询接口出参中回填。ID 不存在或已删除时接口报错 TagNotExist</p>
        /// </summary>
        [JsonProperty("TagId")]
        public string TagId{ get; set; }

        /// <summary>
        /// <p>标签名称。按名称模式接口（AttachWorkspaceUserTags / DetachWorkspaceUserTags）中必填；ID 模式写接口（UpdateWorkspaceUsersTags / UpdateWorkspaceGroupsTags）中无需传入，服务端忽略；查询接口出参中回填</p>
        /// </summary>
        [JsonProperty("TagName")]
        public string TagName{ get; set; }

        /// <summary>
        /// <p>该标签维度下绑定的标签值集合，元素结构见 TagValueInfo。ID 模式写接口中元素 TagValueId 必填；按名称模式接口中元素 TagValue 必填；查询接口出参中回填</p>
        /// </summary>
        [JsonProperty("Values")]
        public TagValueInfo[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagId", this.TagId);
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamArrayObj(map, prefix + "Values.", this.Values);
        }
    }
}

