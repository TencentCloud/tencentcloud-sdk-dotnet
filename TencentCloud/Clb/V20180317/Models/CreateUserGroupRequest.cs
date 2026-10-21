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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUserGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型路由实例ID。用户组将创建在该实例下。</p>
        /// </summary>
        [JsonProperty("ModelRouterId")]
        public string ModelRouterId{ get; set; }

        /// <summary>
        /// <p>用户组名称。必填。同一模型路由实例下名称唯一，长度不超过255个字符。</p>
        /// </summary>
        [JsonProperty("UserGroupName")]
        public string UserGroupName{ get; set; }

        /// <summary>
        /// <p>建组时直接关联的预算 ID（须为已存在的 Budget）。关联后由该 Budget 统一管理本组的消费上限与限速。不传表示不关联预算，可建组后再用 AssociateBudget 关联。</p>
        /// </summary>
        [JsonProperty("BudgetId")]
        public string BudgetId{ get; set; }

        /// <summary>
        /// <p>建组时绑定的 Prompt 资源 ID（pmt-xxx，须为该实例下已存在的 Prompt）。与 PromptVersion 必须成对传入，仅传其一将返回错误。不传表示默认不绑定 Prompt，可建组后再调用 ModifyUserGroupPrompt 绑定或更换版本。绑定后，组内 Key 的请求将按该版本 Prompt 的 Content 与 RewriteStrategy 注入或改写 system 内容。</p>
        /// </summary>
        [JsonProperty("PromptId")]
        public string PromptId{ get; set; }

        /// <summary>
        /// <p>绑定的 Prompt 版本号（如 v1、v2，由 CreatePrompt / CreatePromptVersion 生成，长度不超过16个字符），与 PromptId 必须成对传入，须为该 Prompt 下已存在的版本。版本为不可变快照，Prompt 后续新增版本不会自动生效于已绑定的用户组，需显式重新绑定新版本。一个用户组同时只关联一份 Prompt 的一个版本，重复绑定即为替换。</p>
        /// </summary>
        [JsonProperty("PromptVersion")]
        public string PromptVersion{ get; set; }

        /// <summary>
        /// <p>用户组意图路由白名单（ir-xxx）。每一项须为该实例已创建的意图路由名。命中意图路由名时其内部真实模型自动豁免白名单。为空表示不授权任何意图路由。</p>
        /// </summary>
        [JsonProperty("IntentRouters")]
        public string[] IntentRouters{ get; set; }

        /// <summary>
        /// <p>建组时同时绑定的已有 Key ID 列表，最多100个。每个 Key 须属于同一模型路由实例。建组与绑定为一个原子异步任务，任一 Key 失败则整组创建回滚。不传表示建空组。</p>
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }

        /// <summary>
        /// <p>用户组真实模型白名单。每一项须为该实例已关联的模型名。为空表示不在用户组层限制真实模型（按实例层白名单生效）。</p>
        /// </summary>
        [JsonProperty("Models")]
        public string[] Models{ get; set; }

        /// <summary>
        /// <p>标签列表，最多50个。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelRouterId", this.ModelRouterId);
            this.SetParamSimple(map, prefix + "UserGroupName", this.UserGroupName);
            this.SetParamSimple(map, prefix + "BudgetId", this.BudgetId);
            this.SetParamSimple(map, prefix + "PromptId", this.PromptId);
            this.SetParamSimple(map, prefix + "PromptVersion", this.PromptVersion);
            this.SetParamArraySimple(map, prefix + "IntentRouters.", this.IntentRouters);
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
            this.SetParamArraySimple(map, prefix + "Models.", this.Models);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

