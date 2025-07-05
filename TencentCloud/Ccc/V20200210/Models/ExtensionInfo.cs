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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtensionInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 分机全名
        /// </summary>
        [JsonProperty("FullExtensionId")]
        public string FullExtensionId{ get; set; }

        /// <summary>
        /// 分机号
        /// </summary>
        [JsonProperty("ExtensionId")]
        public string ExtensionId{ get; set; }

        /// <summary>
        /// 所属技能组列表
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public string SkillGroupId{ get; set; }

        /// <summary>
        /// 分机名称
        /// </summary>
        [JsonProperty("ExtensionName")]
        public string ExtensionName{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public long? ModifyTime{ get; set; }

        /// <summary>
        /// 话机状态(0 离线、100 空闲、200忙碌）
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 是否注册
        /// </summary>
        [JsonProperty("Register")]
        public bool? Register{ get; set; }

        /// <summary>
        /// 绑定座席邮箱
        /// </summary>
        [JsonProperty("Relation")]
        public string Relation{ get; set; }

        /// <summary>
        /// 绑定座席名称
        /// </summary>
        [JsonProperty("RelationName")]
        public string RelationName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "FullExtensionId", this.FullExtensionId);
            this.SetParamSimple(map, prefix + "ExtensionId", this.ExtensionId);
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "ExtensionName", this.ExtensionName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Register", this.Register);
            this.SetParamSimple(map, prefix + "Relation", this.Relation);
            this.SetParamSimple(map, prefix + "RelationName", this.RelationName);
        }
    }
}

