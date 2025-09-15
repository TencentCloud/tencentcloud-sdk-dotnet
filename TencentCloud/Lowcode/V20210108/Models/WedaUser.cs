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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WedaUser : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云主账号uin
        /// </summary>
        [JsonProperty("Uin")]
        public long? Uin{ get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 环境
        /// </summary>
        [JsonProperty("Env")]
        public long? Env{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 用户uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 渠道，1:自建；2:企业微信导入
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 微信openid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 关联角色
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelatedRoles")]
        public WedaRole[] RelatedRoles{ get; set; }

        /// <summary>
        /// 企业微信userid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatUserId")]
        public string WechatUserId{ get; set; }

        /// <summary>
        /// 内部用户类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternalUserType")]
        public long? InternalUserType{ get; set; }

        /// <summary>
        /// 微搭用户id
        /// </summary>
        [JsonProperty("UserId")]
        public long? UserId{ get; set; }

        /// <summary>
        /// 所属部门名称
        /// </summary>
        [JsonProperty("OrgName")]
        public string OrgName{ get; set; }

        /// <summary>
        /// 用户schema
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserSchema")]
        public string UserSchema{ get; set; }

        /// <summary>
        /// 用户扩展信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserExtend")]
        public string UserExtend{ get; set; }

        /// <summary>
        /// 用户是否授权License
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsLicensed")]
        public bool? IsLicensed{ get; set; }

        /// <summary>
        /// 权限组数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelatedRoleGroups")]
        public RoleGroup[] RelatedRoleGroups{ get; set; }

        /// <summary>
        /// 兼岗部门
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Orgs")]
        public OrgResp[] Orgs{ get; set; }

        /// <summary>
        /// 主岗部门
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MainOrg")]
        public OrgResp[] MainOrg{ get; set; }

        /// <summary>
        /// 直属上级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentUserId")]
        public long? ParentUserId{ get; set; }

        /// <summary>
        /// 主列字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrimaryColumn")]
        public string PrimaryColumn{ get; set; }

        /// <summary>
        /// 用户头像
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvatarUrl")]
        public string AvatarUrl{ get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        [JsonProperty("LastLoginTime")]
        public string LastLoginTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Env", this.Env);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamArrayObj(map, prefix + "RelatedRoles.", this.RelatedRoles);
            this.SetParamSimple(map, prefix + "WechatUserId", this.WechatUserId);
            this.SetParamSimple(map, prefix + "InternalUserType", this.InternalUserType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "OrgName", this.OrgName);
            this.SetParamSimple(map, prefix + "UserSchema", this.UserSchema);
            this.SetParamSimple(map, prefix + "UserExtend", this.UserExtend);
            this.SetParamSimple(map, prefix + "IsLicensed", this.IsLicensed);
            this.SetParamArrayObj(map, prefix + "RelatedRoleGroups.", this.RelatedRoleGroups);
            this.SetParamArrayObj(map, prefix + "Orgs.", this.Orgs);
            this.SetParamArrayObj(map, prefix + "MainOrg.", this.MainOrg);
            this.SetParamSimple(map, prefix + "ParentUserId", this.ParentUserId);
            this.SetParamSimple(map, prefix + "PrimaryColumn", this.PrimaryColumn);
            this.SetParamSimple(map, prefix + "AvatarUrl", this.AvatarUrl);
            this.SetParamSimple(map, prefix + "LastLoginTime", this.LastLoginTime);
        }
    }
}

