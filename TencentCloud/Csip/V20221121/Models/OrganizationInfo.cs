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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrganizationInfo : AbstractModel
    {
        
        /// <summary>
        /// 成员账号名称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 部门节点名称，账号所属部门
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Member/Admin/DelegatedAdmin/EntityAdmin; 成员/管理员/委派管理员/主体管理员
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 成员账号id
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// 账号加入方式,create/invite
        /// </summary>
        [JsonProperty("JoinType")]
        public string JoinType{ get; set; }

        /// <summary>
        /// 集团名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 管理员账号名称
        /// </summary>
        [JsonProperty("AdminName")]
        public string AdminName{ get; set; }

        /// <summary>
        /// 管理员Uin
        /// </summary>
        [JsonProperty("AdminUin")]
        public string AdminUin{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 部门数
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// 成员数
        /// </summary>
        [JsonProperty("MemberCount")]
        public long? MemberCount{ get; set; }

        /// <summary>
        /// 子账号数
        /// </summary>
        [JsonProperty("SubAccountCount")]
        public long? SubAccountCount{ get; set; }

        /// <summary>
        /// 异常子账号数量
        /// </summary>
        [JsonProperty("AbnormalSubUserCount")]
        public long? AbnormalSubUserCount{ get; set; }

        /// <summary>
        /// 集团关系策略权限
        /// </summary>
        [JsonProperty("GroupPermission")]
        public string[] GroupPermission{ get; set; }

        /// <summary>
        /// 成员关系策略权限
        /// </summary>
        [JsonProperty("MemberPermission")]
        public string[] MemberPermission{ get; set; }

        /// <summary>
        /// 集团付费模式；0/自付费，1/代付费
        /// </summary>
        [JsonProperty("GroupPayMode")]
        public long? GroupPayMode{ get; set; }

        /// <summary>
        /// 个人付费模式；0/自付费，1/代付费
        /// </summary>
        [JsonProperty("MemberPayMode")]
        public long? MemberPayMode{ get; set; }

        /// <summary>
        /// 空则未开启，否则不同字符串对应不同版本，common为通用，不区分版本
        /// </summary>
        [JsonProperty("CFWProtect")]
        public string CFWProtect{ get; set; }

        /// <summary>
        /// 空则未开启，否则不同字符串对应不同版本，common为通用，不区分版本
        /// </summary>
        [JsonProperty("WAFProtect")]
        public string WAFProtect{ get; set; }

        /// <summary>
        /// 空则未开启，否则不同字符串对应不同版本，common为通用，不区分版本
        /// </summary>
        [JsonProperty("CWPProtect")]
        public string CWPProtect{ get; set; }

        /// <summary>
        /// 所有部门的集合数组
        /// </summary>
        [JsonProperty("Departments")]
        public string[] Departments{ get; set; }

        /// <summary>
        /// 成员创建时间
        /// </summary>
        [JsonProperty("MemberCreateTime")]
        public string MemberCreateTime{ get; set; }

        /// <summary>
        /// Advanced/Enterprise/Ultimate 
        /// </summary>
        [JsonProperty("CSIPProtect")]
        public string CSIPProtect{ get; set; }

        /// <summary>
        /// 1表示配额消耗方
        /// </summary>
        [JsonProperty("QuotaConsumer")]
        public long? QuotaConsumer{ get; set; }

        /// <summary>
        /// 管理员/委派管理员 已开启数量
        /// </summary>
        [JsonProperty("EnableAdminCount")]
        public long? EnableAdminCount{ get; set; }

        /// <summary>
        /// 账户多云信息统计，数组形式，具体参考CloudCountDesc描述
        /// </summary>
        [JsonProperty("CloudCountDesc")]
        public CloudCountDesc[] CloudCountDesc{ get; set; }

        /// <summary>
        /// 管理员/委派管理员 总数量
        /// </summary>
        [JsonProperty("AdminCount")]
        public long? AdminCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "MemberId", this.MemberId);
            this.SetParamSimple(map, prefix + "JoinType", this.JoinType);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "AdminName", this.AdminName);
            this.SetParamSimple(map, prefix + "AdminUin", this.AdminUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "MemberCount", this.MemberCount);
            this.SetParamSimple(map, prefix + "SubAccountCount", this.SubAccountCount);
            this.SetParamSimple(map, prefix + "AbnormalSubUserCount", this.AbnormalSubUserCount);
            this.SetParamArraySimple(map, prefix + "GroupPermission.", this.GroupPermission);
            this.SetParamArraySimple(map, prefix + "MemberPermission.", this.MemberPermission);
            this.SetParamSimple(map, prefix + "GroupPayMode", this.GroupPayMode);
            this.SetParamSimple(map, prefix + "MemberPayMode", this.MemberPayMode);
            this.SetParamSimple(map, prefix + "CFWProtect", this.CFWProtect);
            this.SetParamSimple(map, prefix + "WAFProtect", this.WAFProtect);
            this.SetParamSimple(map, prefix + "CWPProtect", this.CWPProtect);
            this.SetParamArraySimple(map, prefix + "Departments.", this.Departments);
            this.SetParamSimple(map, prefix + "MemberCreateTime", this.MemberCreateTime);
            this.SetParamSimple(map, prefix + "CSIPProtect", this.CSIPProtect);
            this.SetParamSimple(map, prefix + "QuotaConsumer", this.QuotaConsumer);
            this.SetParamSimple(map, prefix + "EnableAdminCount", this.EnableAdminCount);
            this.SetParamArrayObj(map, prefix + "CloudCountDesc.", this.CloudCountDesc);
            this.SetParamSimple(map, prefix + "AdminCount", this.AdminCount);
        }
    }
}

