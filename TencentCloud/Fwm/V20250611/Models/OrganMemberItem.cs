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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrganMemberItem : AbstractModel
    {
        
        /// <summary>
        /// <p>成员 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// <p>成员账号 AppId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>账号Uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>账号名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// <p>子账号数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountCount")]
        public long? SubAccountCount{ get; set; }

        /// <summary>
        /// <p>所属组织架构节点名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>成员身份：admin-管理员，delegatedAdmin-委派管理员，member-普通成员</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>成员身份显示名称（前端展示用）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoleDisplay")]
        public string RoleDisplay{ get; set; }

        /// <summary>
        /// <p>所属账户组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountGroup")]
        public AccountGroupInfo AccountGroup{ get; set; }

        /// <summary>
        /// <p>云防火墙纳管状态：0-未纳管，1-已纳管</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CfwManaged")]
        public long? CfwManaged{ get; set; }

        /// <summary>
        /// <p>云防火墙共享角色：sharer-共享者，user-使用者，none-未设置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CfwShareRole")]
        public string CfwShareRole{ get; set; }

        /// <summary>
        /// <p>云防火墙共享角色显示名称（前端展示用）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CfwShareRoleDisplay")]
        public string CfwShareRoleDisplay{ get; set; }

        /// <summary>
        /// <p>云防火墙共享者 AppId，成员角色为使用者时有值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CfwSharerAppId")]
        public string CfwSharerAppId{ get; set; }

        /// <summary>
        /// <p>云防火墙计费实例 ID，非空表示已购买云防火墙</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CfwInstanceId")]
        public string CfwInstanceId{ get; set; }

        /// <summary>
        /// <p>策略分析权限：0-关闭，1-开启</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicyAnalysisEnabled")]
        public long? PolicyAnalysisEnabled{ get; set; }

        /// <summary>
        /// <p>成员加入集团时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberCreateTime")]
        public string MemberCreateTime{ get; set; }

        /// <summary>
        /// <p>账号加入方式</p>
        /// </summary>
        [JsonProperty("JoinType")]
        public string JoinType{ get; set; }

        /// <summary>
        /// <p>云防火墙套餐状态</p><p>枚举值：</p><ul><li>0： 未购买</li><li>2： 已购买</li><li>3： 试用中</li><li>4： 已过期</li></ul>
        /// </summary>
        [JsonProperty("CfwPayStatus")]
        public long? CfwPayStatus{ get; set; }

        /// <summary>
        /// <p>是否具备云防火墙使用能力</p>
        /// </summary>
        [JsonProperty("CfwCapable")]
        public long? CfwCapable{ get; set; }

        /// <summary>
        /// <p>私有安全组纳管开关， 0:未纳管，1:已纳管</p>
        /// </summary>
        [JsonProperty("SgManaged")]
        public long? SgManaged{ get; set; }

        /// <summary>
        /// <p>是否是后付费云防版本</p><p>枚举值：</p><ul><li>1： 后付费</li><li>0： 非后付费</li><li>-1： 未知</li></ul>
        /// </summary>
        [JsonProperty("IsCfwPostPay")]
        public long? IsCfwPostPay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberId", this.MemberId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "SubAccountCount", this.SubAccountCount);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "RoleDisplay", this.RoleDisplay);
            this.SetParamObj(map, prefix + "AccountGroup.", this.AccountGroup);
            this.SetParamSimple(map, prefix + "CfwManaged", this.CfwManaged);
            this.SetParamSimple(map, prefix + "CfwShareRole", this.CfwShareRole);
            this.SetParamSimple(map, prefix + "CfwShareRoleDisplay", this.CfwShareRoleDisplay);
            this.SetParamSimple(map, prefix + "CfwSharerAppId", this.CfwSharerAppId);
            this.SetParamSimple(map, prefix + "CfwInstanceId", this.CfwInstanceId);
            this.SetParamSimple(map, prefix + "PolicyAnalysisEnabled", this.PolicyAnalysisEnabled);
            this.SetParamSimple(map, prefix + "MemberCreateTime", this.MemberCreateTime);
            this.SetParamSimple(map, prefix + "JoinType", this.JoinType);
            this.SetParamSimple(map, prefix + "CfwPayStatus", this.CfwPayStatus);
            this.SetParamSimple(map, prefix + "CfwCapable", this.CfwCapable);
            this.SetParamSimple(map, prefix + "SgManaged", this.SgManaged);
            this.SetParamSimple(map, prefix + "IsCfwPostPay", this.IsCfwPostPay);
        }
    }
}

