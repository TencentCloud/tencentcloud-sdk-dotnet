/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateExtensionRequest : AbstractModel
    {
        
        /// <summary>
        /// TCCC 实例应用 ID
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 分机号
        /// </summary>
        [JsonProperty("ExtensionId")]
        public string ExtensionId{ get; set; }

        /// <summary>
        /// 分机名称
        /// </summary>
        [JsonProperty("ExtensionName")]
        public string ExtensionName{ get; set; }

        /// <summary>
        /// 绑定的技能组列表
        /// </summary>
        [JsonProperty("SkillGroupIds")]
        public ulong?[] SkillGroupIds{ get; set; }

        /// <summary>
        /// 绑定的坐席邮箱
        /// </summary>
        [JsonProperty("Relation")]
        public string Relation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "ExtensionId", this.ExtensionId);
            this.SetParamSimple(map, prefix + "ExtensionName", this.ExtensionName);
            this.SetParamArraySimple(map, prefix + "SkillGroupIds.", this.SkillGroupIds);
            this.SetParamSimple(map, prefix + "Relation", this.Relation);
        }
    }
}

