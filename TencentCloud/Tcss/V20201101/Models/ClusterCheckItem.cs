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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterCheckItem : AbstractModel
    {
        
        /// <summary>
        /// 唯一的检测项的ID
        /// </summary>
        [JsonProperty("CheckItemId")]
        public long? CheckItemId{ get; set; }

        /// <summary>
        /// 风险项的名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 检测项详细描述。
        /// </summary>
        [JsonProperty("ItemDetail")]
        public string ItemDetail{ get; set; }

        /// <summary>
        /// 威胁等级。严重Serious,高危High,中危Middle,提示Hint
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 检查对象、风险对象.Runc,Kubelet,Containerd,Pods
        /// </summary>
        [JsonProperty("RiskTarget")]
        public string RiskTarget{ get; set; }

        /// <summary>
        /// 风险类别,漏洞风险CVERisk,配置风险ConfigRisk
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// 检测项所属的风险类型,权限提升:PrivilegePromotion,拒绝服务:RefuseService,目录穿越:DirectoryEscape,未授权访问:UnauthorizedAccess,权限许可和访问控制问题:PrivilegeAndAccessControl,敏感信息泄露:SensitiveInfoLeak
        /// </summary>
        [JsonProperty("RiskAttribute")]
        public string RiskAttribute{ get; set; }

        /// <summary>
        /// 风险特征,Tag.存在EXP:ExistEXP,存在POD:ExistPOC,无需重启:NoNeedReboot, 服务重启:ServerRestart,远程信息泄露:RemoteInfoLeak,远程拒绝服务:RemoteRefuseService,远程利用:RemoteExploit,远程执行:RemoteExecute
        /// </summary>
        [JsonProperty("RiskProperty")]
        public string RiskProperty{ get; set; }

        /// <summary>
        /// CVE编号
        /// </summary>
        [JsonProperty("CVENumber")]
        public string CVENumber{ get; set; }

        /// <summary>
        /// 披露时间
        /// </summary>
        [JsonProperty("DiscoverTime")]
        public string DiscoverTime{ get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// CVSS信息,用于画图
        /// </summary>
        [JsonProperty("CVSS")]
        public string CVSS{ get; set; }

        /// <summary>
        /// CVSS分数
        /// </summary>
        [JsonProperty("CVSSScore")]
        public string CVSSScore{ get; set; }

        /// <summary>
        /// 参考连接
        /// </summary>
        [JsonProperty("RelateLink")]
        public string RelateLink{ get; set; }

        /// <summary>
        /// 影响类型，为Node或者Workload
        /// </summary>
        [JsonProperty("AffectedType")]
        public string AffectedType{ get; set; }

        /// <summary>
        /// 受影响的版本信息
        /// </summary>
        [JsonProperty("AffectedVersion")]
        public string AffectedVersion{ get; set; }

        /// <summary>
        /// 忽略的资产数量
        /// </summary>
        [JsonProperty("IgnoredAssetNum")]
        public long? IgnoredAssetNum{ get; set; }

        /// <summary>
        /// 是否忽略该检测项
        /// </summary>
        [JsonProperty("IsIgnored")]
        public bool? IsIgnored{ get; set; }

        /// <summary>
        /// 受影响评估
        /// </summary>
        [JsonProperty("RiskAssessment")]
        public string RiskAssessment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckItemId", this.CheckItemId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ItemDetail", this.ItemDetail);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RiskTarget", this.RiskTarget);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "RiskAttribute", this.RiskAttribute);
            this.SetParamSimple(map, prefix + "RiskProperty", this.RiskProperty);
            this.SetParamSimple(map, prefix + "CVENumber", this.CVENumber);
            this.SetParamSimple(map, prefix + "DiscoverTime", this.DiscoverTime);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "CVSS", this.CVSS);
            this.SetParamSimple(map, prefix + "CVSSScore", this.CVSSScore);
            this.SetParamSimple(map, prefix + "RelateLink", this.RelateLink);
            this.SetParamSimple(map, prefix + "AffectedType", this.AffectedType);
            this.SetParamSimple(map, prefix + "AffectedVersion", this.AffectedVersion);
            this.SetParamSimple(map, prefix + "IgnoredAssetNum", this.IgnoredAssetNum);
            this.SetParamSimple(map, prefix + "IsIgnored", this.IsIgnored);
            this.SetParamSimple(map, prefix + "RiskAssessment", this.RiskAssessment);
        }
    }
}

