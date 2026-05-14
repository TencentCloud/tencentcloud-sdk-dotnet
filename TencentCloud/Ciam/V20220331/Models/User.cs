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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class User : AbstractModel
    {
        
        /// <summary>
        /// <p>用户ID</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>手机号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// <p>邮箱</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// <p>上次登录时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastSignOn")]
        public long? LastSignOn{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreatedDate")]
        public long? CreatedDate{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>用户来源</p>
        /// </summary>
        [JsonProperty("UserDataSourceEnum")]
        public string UserDataSourceEnum{ get; set; }

        /// <summary>
        /// <p>昵称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// <p>地址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>生日</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Birthdate")]
        public long? Birthdate{ get; set; }

        /// <summary>
        /// <p>用户组ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserGroups")]
        public string[] UserGroups{ get; set; }

        /// <summary>
        /// <p>用户组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserGroupNames")]
        public string[] UserGroupNames{ get; set; }

        /// <summary>
        /// <p>上次修改时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModifiedDate")]
        public long? LastModifiedDate{ get; set; }

        /// <summary>
        /// <p>自定义属性</p>
        /// </summary>
        [JsonProperty("CustomAttributes")]
        public MemberMap[] CustomAttributes{ get; set; }

        /// <summary>
        /// <p>身份证号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResidentIdentityCard")]
        public string ResidentIdentityCard{ get; set; }

        /// <summary>
        /// <p>QQ的OpenId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QqOpenId")]
        public string QqOpenId{ get; set; }

        /// <summary>
        /// <p>QQ的UnionId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QqUnionId")]
        public string QqUnionId{ get; set; }

        /// <summary>
        /// <p>微信的WechatOpenId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatOpenId")]
        public string WechatOpenId{ get; set; }

        /// <summary>
        /// <p>微信的WechatUnionId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatUnionId")]
        public string WechatUnionId{ get; set; }

        /// <summary>
        /// <p>支付宝的AlipayUserId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlipayUserId")]
        public string AlipayUserId{ get; set; }

        /// <summary>
        /// <p>企业微信的WeComUserId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeComUserId")]
        public string WeComUserId{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>姓名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>坐标</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Locale")]
        public string Locale{ get; set; }

        /// <summary>
        /// <p>性别</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// <p>实名核验方式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdentityVerificationMethod")]
        public string IdentityVerificationMethod{ get; set; }

        /// <summary>
        /// <p>是否已经实名核验</p>
        /// </summary>
        [JsonProperty("IdentityVerified")]
        public bool? IdentityVerified{ get; set; }

        /// <summary>
        /// <p>工作</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Job")]
        public string Job{ get; set; }

        /// <summary>
        /// <p>国家</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// <p>是否主账号（进行过账号融合后，主账号为true，从账号为false）</p>
        /// </summary>
        [JsonProperty("Primary")]
        public bool? Primary{ get; set; }

        /// <summary>
        /// <p>时区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>是否已经首次登录</p>
        /// </summary>
        [JsonProperty("AlreadyFirstLogin")]
        public bool? AlreadyFirstLogin{ get; set; }

        /// <summary>
        /// <p>租户id</p>
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// <p>用户目录id</p>
        /// </summary>
        [JsonProperty("UserStoreId")]
        public string UserStoreId{ get; set; }

        /// <summary>
        /// <p>版本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public long? Version{ get; set; }

        /// <summary>
        /// <p>锁定类型（分为管理员锁定，和登录策略锁定）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockType")]
        public string LockType{ get; set; }

        /// <summary>
        /// <p>锁定时间点</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LockTime")]
        public long? LockTime{ get; set; }

        /// <summary>
        /// <p>索引字段1</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexedAttribute1")]
        public string IndexedAttribute1{ get; set; }

        /// <summary>
        /// <p>索引字段2</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexedAttribute2")]
        public string IndexedAttribute2{ get; set; }

        /// <summary>
        /// <p>索引字段3</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexedAttribute3")]
        public string IndexedAttribute3{ get; set; }

        /// <summary>
        /// <p>索引字段4</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexedAttribute4")]
        public string IndexedAttribute4{ get; set; }

        /// <summary>
        /// <p>索引字段5</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexedAttribute5")]
        public string IndexedAttribute5{ get; set; }

        /// <summary>
        /// <p>用户所属组织机构ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserOrgs")]
        public string[] UserOrgs{ get; set; }

        /// <summary>
        /// <p>用户所属企业微信组织机构</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeComUserOrgs")]
        public long?[] WeComUserOrgs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "LastSignOn", this.LastSignOn);
            this.SetParamSimple(map, prefix + "CreatedDate", this.CreatedDate);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UserDataSourceEnum", this.UserDataSourceEnum);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Birthdate", this.Birthdate);
            this.SetParamArraySimple(map, prefix + "UserGroups.", this.UserGroups);
            this.SetParamArraySimple(map, prefix + "UserGroupNames.", this.UserGroupNames);
            this.SetParamSimple(map, prefix + "LastModifiedDate", this.LastModifiedDate);
            this.SetParamArrayObj(map, prefix + "CustomAttributes.", this.CustomAttributes);
            this.SetParamSimple(map, prefix + "ResidentIdentityCard", this.ResidentIdentityCard);
            this.SetParamSimple(map, prefix + "QqOpenId", this.QqOpenId);
            this.SetParamSimple(map, prefix + "QqUnionId", this.QqUnionId);
            this.SetParamSimple(map, prefix + "WechatOpenId", this.WechatOpenId);
            this.SetParamSimple(map, prefix + "WechatUnionId", this.WechatUnionId);
            this.SetParamSimple(map, prefix + "AlipayUserId", this.AlipayUserId);
            this.SetParamSimple(map, prefix + "WeComUserId", this.WeComUserId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Locale", this.Locale);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "IdentityVerificationMethod", this.IdentityVerificationMethod);
            this.SetParamSimple(map, prefix + "IdentityVerified", this.IdentityVerified);
            this.SetParamSimple(map, prefix + "Job", this.Job);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "Primary", this.Primary);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "AlreadyFirstLogin", this.AlreadyFirstLogin);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "UserStoreId", this.UserStoreId);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "LockType", this.LockType);
            this.SetParamSimple(map, prefix + "LockTime", this.LockTime);
            this.SetParamSimple(map, prefix + "IndexedAttribute1", this.IndexedAttribute1);
            this.SetParamSimple(map, prefix + "IndexedAttribute2", this.IndexedAttribute2);
            this.SetParamSimple(map, prefix + "IndexedAttribute3", this.IndexedAttribute3);
            this.SetParamSimple(map, prefix + "IndexedAttribute4", this.IndexedAttribute4);
            this.SetParamSimple(map, prefix + "IndexedAttribute5", this.IndexedAttribute5);
            this.SetParamArraySimple(map, prefix + "UserOrgs.", this.UserOrgs);
            this.SetParamArraySimple(map, prefix + "WeComUserOrgs.", this.WeComUserOrgs);
        }
    }
}

