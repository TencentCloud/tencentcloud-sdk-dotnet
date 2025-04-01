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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Project : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 项目Logo
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Logo")]
        public string Logo{ get; set; }

        /// <summary>
        /// 项目名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// logo底色
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColorCode")]
        public string ColorCode{ get; set; }

        /// <summary>
        /// 创建人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedUser")]
        public string CreatedUser{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 成员个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberCount")]
        public long? MemberCount{ get; set; }

        /// <summary>
        /// 页面个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageCount")]
        public long? PageCount{ get; set; }

        /// <summary>
        /// 最后修改报表、简报名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModifyName")]
        public string LastModifyName{ get; set; }

        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Apply")]
        public bool? Apply{ get; set; }

        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedUser")]
        public string UpdatedUser{ get; set; }

        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CorpId")]
        public string CorpId{ get; set; }

        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mark")]
        public string Mark{ get; set; }

        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Seed")]
        public string Seed{ get; set; }

        /// <summary>
        /// 项目内权限列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthList")]
        public string[] AuthList{ get; set; }

        /// <summary>
        /// 默认看板
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PanelScope")]
        public string PanelScope{ get; set; }

        /// <summary>
        /// 是否被托管
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsExternalManage")]
        public bool? IsExternalManage{ get; set; }

        /// <summary>
        /// 托管平台名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManagePlatform")]
        public string ManagePlatform{ get; set; }

        /// <summary>
        /// 定制化参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigList")]
        public ProjectConfigList[] ConfigList{ get; set; }

        /// <summary>
        /// 创建人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedUserName")]
        public string CreatedUserName{ get; set; }

        /// <summary>
        /// 所属人id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 所属人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Logo", this.Logo);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ColorCode", this.ColorCode);
            this.SetParamSimple(map, prefix + "CreatedUser", this.CreatedUser);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "MemberCount", this.MemberCount);
            this.SetParamSimple(map, prefix + "PageCount", this.PageCount);
            this.SetParamSimple(map, prefix + "LastModifyName", this.LastModifyName);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Apply", this.Apply);
            this.SetParamSimple(map, prefix + "UpdatedUser", this.UpdatedUser);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamSimple(map, prefix + "Mark", this.Mark);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamArraySimple(map, prefix + "AuthList.", this.AuthList);
            this.SetParamSimple(map, prefix + "PanelScope", this.PanelScope);
            this.SetParamSimple(map, prefix + "IsExternalManage", this.IsExternalManage);
            this.SetParamSimple(map, prefix + "ManagePlatform", this.ManagePlatform);
            this.SetParamArrayObj(map, prefix + "ConfigList.", this.ConfigList);
            this.SetParamSimple(map, prefix + "CreatedUserName", this.CreatedUserName);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
        }
    }
}

