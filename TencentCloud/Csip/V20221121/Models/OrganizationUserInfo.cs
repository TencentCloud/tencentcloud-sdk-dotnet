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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrganizationUserInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>成员账号Uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>成员账号名称</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// <p>部门节点名称，账号所属部门</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>资产数量</p>
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// <p>风险数量</p>
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// <p>攻击数量</p>
        /// </summary>
        [JsonProperty("AttackCount")]
        public long? AttackCount{ get; set; }

        /// <summary>
        /// <p>Member/Admin/;成员或者管理员</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>成员账号id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// <p>成员账号Appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>账号加入方式,create/invite</p>
        /// </summary>
        [JsonProperty("JoinType")]
        public string JoinType{ get; set; }

        /// <summary>
        /// <p>空则未开启，否则不同字符串对应不同版本，common为通用，不区分版本</p>
        /// </summary>
        [JsonProperty("CFWProtect")]
        public string CFWProtect{ get; set; }

        /// <summary>
        /// <p>空则未开启，否则不同字符串对应不同版本，common为通用，不区分版本</p>
        /// </summary>
        [JsonProperty("WAFProtect")]
        public string WAFProtect{ get; set; }

        /// <summary>
        /// <p>空则未开启，否则不同字符串对应不同版本，common为通用，不区分版本</p>
        /// </summary>
        [JsonProperty("CWPProtect")]
        public string CWPProtect{ get; set; }

        /// <summary>
        /// <p>1启用，0未启用</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// <p>&quot;Free&quot;       //免费版  &quot;Advanced&quot;   //高级版 &quot;Enterprise&quot; //企业版 &quot;Ultimate&quot;   //旗舰版</p>
        /// </summary>
        [JsonProperty("CSIPProtect")]
        public string CSIPProtect{ get; set; }

        /// <summary>
        /// <p>1为配额消耗者</p>
        /// </summary>
        [JsonProperty("QuotaConsumer")]
        public long? QuotaConsumer{ get; set; }

        /// <summary>
        /// <p>账户类型，0为腾讯云账户，1为AWS账户</p>
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// <p>0为缺省值，1为10分钟，2为1小时，3为24小时</p>
        /// </summary>
        [JsonProperty("SyncFrequency")]
        public long? SyncFrequency{ get; set; }

        /// <summary>
        /// <p>多云账户是否过期</p>
        /// </summary>
        [JsonProperty("IsExpired")]
        public bool? IsExpired{ get; set; }

        /// <summary>
        /// <p>多云账户 权限列表</p>
        /// </summary>
        [JsonProperty("PermissionList")]
        public string[] PermissionList{ get; set; }

        /// <summary>
        /// <p>账户权限类型</p><p>枚举值：</p><ul><li>1： 认证类型-Root账号AKSK</li><li>2： 认证类型-子账号AKSK</li><li>3： 认证类型-角色</li></ul>
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }

        /// <summary>
        /// <p>0 腾讯云集团账户<br>1 腾讯云接入账户<br>2 非腾讯云</p>
        /// </summary>
        [JsonProperty("TcMemberType")]
        public long? TcMemberType{ get; set; }

        /// <summary>
        /// <p>子账号数量</p>
        /// </summary>
        [JsonProperty("SubUserCount")]
        public long? SubUserCount{ get; set; }

        /// <summary>
        /// <p>加入方式详细信息</p>
        /// </summary>
        [JsonProperty("JoinTypeInfo")]
        public string JoinTypeInfo{ get; set; }

        /// <summary>
        /// <p>被共享模块列表</p><p>枚举值：</p><ul><li>AKSK： 云API异常监测</li><li>SDL： 日志分析</li><li>CSPM： 云安全态势管理</li><li>CWP： 主机安全</li><li>COS_AUDIT： COS审计</li><li>IMAGE_SCAN： 容器镜像扫描</li><li>SKILL_SCAN： Skill安全检测</li><li>SKILL_SCAN_POST： Skill安全检测(后付费)</li><li>DSPM： 数据安全态势管理</li></ul><p>默认值：[]</p>
        /// </summary>
        [JsonProperty("SharedModules")]
        public string[] SharedModules{ get; set; }

        /// <summary>
        /// <p>安全分</p>
        /// </summary>
        [JsonProperty("SecurityScore")]
        public long? SecurityScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "AttackCount", this.AttackCount);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "MemberId", this.MemberId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "JoinType", this.JoinType);
            this.SetParamSimple(map, prefix + "CFWProtect", this.CFWProtect);
            this.SetParamSimple(map, prefix + "WAFProtect", this.WAFProtect);
            this.SetParamSimple(map, prefix + "CWPProtect", this.CWPProtect);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "CSIPProtect", this.CSIPProtect);
            this.SetParamSimple(map, prefix + "QuotaConsumer", this.QuotaConsumer);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "SyncFrequency", this.SyncFrequency);
            this.SetParamSimple(map, prefix + "IsExpired", this.IsExpired);
            this.SetParamArraySimple(map, prefix + "PermissionList.", this.PermissionList);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "TcMemberType", this.TcMemberType);
            this.SetParamSimple(map, prefix + "SubUserCount", this.SubUserCount);
            this.SetParamSimple(map, prefix + "JoinTypeInfo", this.JoinTypeInfo);
            this.SetParamArraySimple(map, prefix + "SharedModules.", this.SharedModules);
            this.SetParamSimple(map, prefix + "SecurityScore", this.SecurityScore);
        }
    }
}

