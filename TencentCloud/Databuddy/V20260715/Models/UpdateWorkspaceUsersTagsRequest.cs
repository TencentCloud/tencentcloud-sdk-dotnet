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

    public class UpdateWorkspaceUsersTagsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>必填，用户UIN列表，单次最多100个</p>
        /// </summary>
        [JsonProperty("UserUins")]
        public string[] UserUins{ get; set; }

        /// <summary>
        /// <p>必填，工作空间ID</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>待更新的标签集合（标签维度及标签值通过 ID 指定），覆盖更新语义：传入后将被覆盖为目标用户的全部直绑标签，不传或传空数组则清空目标用户的所有直绑标签。每个元素中 TagId 必填，Values[].TagValueId 必填；传入的 TagValue、Source、GroupNames 服务端不读取，无需传入。标签维度与标签值可先通过 CreateTags / CreateTagValues 创建，再通过 ListTags 获取 ID（TagId 取 Items[].TagId，TagValueId 取 Items[].TagValues[].TagValueId）。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public UserTagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "UserUins.", this.UserUins);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

