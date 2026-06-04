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

    public class SkillClassification : AbstractModel
    {
        
        /// <summary>
        /// Skill 计费类型
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 免费 |
        /// | 1 | 付费 |
        /// </summary>
        [JsonProperty("BillingType")]
        public long? BillingType{ get; set; }

        /// <summary>
        /// Skill 内置来源，仅在 create_type 为 SKILL_CREATE_TYPE_BUILTIN 时生效
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 占位 |
        /// | 1 | ADP 专有 |
        /// | 2 | 腾讯专有 |
        /// | 3 | SkillHub |
        /// | 99 | 其他 |
        /// </summary>
        [JsonProperty("BuiltinSource")]
        public long? BuiltinSource{ get; set; }

        /// <summary>
        /// Skill 分类
        /// </summary>
        [JsonProperty("CategoryKey")]
        public string CategoryKey{ get; set; }

        /// <summary>
        /// Skill 创建方式
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 占位 |
        /// | 1 | 文件上传 |
        /// | 2 | 由企业级共享流程生成 |
        /// | 3 | AIGC 生成 |
        /// | 99 | 内置 Skill |
        /// </summary>
        [JsonProperty("CreateType")]
        public long? CreateType{ get; set; }

        /// <summary>
        /// Skill 提供方类型
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 占位 |
        /// | 1 | 官方 |
        /// | 2 | 第三方 |
        /// | 3 | 自定义 |
        /// | 4 | 自定义企业级共享 |
        /// </summary>
        [JsonProperty("ProviderType")]
        public long? ProviderType{ get; set; }

        /// <summary>
        /// Skill 来源链接
        /// </summary>
        [JsonProperty("SourceLink")]
        public string SourceLink{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BillingType", this.BillingType);
            this.SetParamSimple(map, prefix + "BuiltinSource", this.BuiltinSource);
            this.SetParamSimple(map, prefix + "CategoryKey", this.CategoryKey);
            this.SetParamSimple(map, prefix + "CreateType", this.CreateType);
            this.SetParamSimple(map, prefix + "ProviderType", this.ProviderType);
            this.SetParamSimple(map, prefix + "SourceLink", this.SourceLink);
        }
    }
}

