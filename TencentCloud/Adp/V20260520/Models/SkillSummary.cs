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

    public class SkillSummary : AbstractModel
    {
        
        /// <summary>
        /// 分类信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassificationInfo")]
        public SkillClassification ClassificationInfo{ get; set; }

        /// <summary>
        /// 当前版本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentVersionInfo")]
        public SkillVersion CurrentVersionInfo{ get; set; }

        /// <summary>
        /// 当前用户是否收藏
        /// </summary>
        [JsonProperty("IsFavorite")]
        public bool? IsFavorite{ get; set; }

        /// <summary>
        /// 基础信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Profile")]
        public SkillProfile Profile{ get; set; }

        /// <summary>
        /// Skill ID
        /// </summary>
        [JsonProperty("SkillId")]
        public string SkillId{ get; set; }

        /// <summary>
        /// Skill 异常通知列表
        /// </summary>
        [JsonProperty("NoticeList")]
        public SkillNotice[] NoticeList{ get; set; }

        /// <summary>
        /// 当前用户对该 Skill 的资源操作权限位列表；内置/共享 Skill 固定为空数组
        /// </summary>
        [JsonProperty("PermissionIdList")]
        public string[] PermissionIdList{ get; set; }

        /// <summary>
        /// 共享信息；可能有两条，一条是已共享的，一条是审核中的
        /// </summary>
        [JsonProperty("ShareList")]
        public SkillShare[] ShareList{ get; set; }

        /// <summary>
        /// Skill状态 
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 初始化（无任何已发布版本，且最新版本处于 INITIALIZED/UNRELEASED） |
        /// | 1 | 安全检测中（无任何已发布版本，且最新版本处于 AUDITING） |
        /// | 2 | 待发布（无任何已发布版本，且最新版本处于 PENDING_RELEASE） |
        /// | 3 | 已发布（存在任一 RELEASED 版本，吸收态） |
        /// </summary>
        [JsonProperty("SkillStatus")]
        public long? SkillStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ClassificationInfo.", this.ClassificationInfo);
            this.SetParamObj(map, prefix + "CurrentVersionInfo.", this.CurrentVersionInfo);
            this.SetParamSimple(map, prefix + "IsFavorite", this.IsFavorite);
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamSimple(map, prefix + "SkillId", this.SkillId);
            this.SetParamArrayObj(map, prefix + "NoticeList.", this.NoticeList);
            this.SetParamArraySimple(map, prefix + "PermissionIdList.", this.PermissionIdList);
            this.SetParamArrayObj(map, prefix + "ShareList.", this.ShareList);
            this.SetParamSimple(map, prefix + "SkillStatus", this.SkillStatus);
        }
    }
}

