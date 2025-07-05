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

    public class BugInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// 漏洞编号
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 漏洞对应pocId
        /// </summary>
        [JsonProperty("PatchId")]
        public string PatchId{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VULName")]
        public string VULName{ get; set; }

        /// <summary>
        /// 漏洞严重性：high,middle，low，info
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// cvss评分
        /// </summary>
        [JsonProperty("CVSSScore")]
        public string CVSSScore{ get; set; }

        /// <summary>
        /// cve编号
        /// </summary>
        [JsonProperty("CVEId")]
        public string CVEId{ get; set; }

        /// <summary>
        /// 漏洞标签
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 漏洞种类，1:web应用，2:系统组件漏洞，3:配置风险
        /// </summary>
        [JsonProperty("VULCategory")]
        public ulong? VULCategory{ get; set; }

        /// <summary>
        /// 漏洞影响系统
        /// </summary>
        [JsonProperty("ImpactOs")]
        public string ImpactOs{ get; set; }

        /// <summary>
        /// 漏洞影响组件
        /// </summary>
        [JsonProperty("ImpactCOMPENT")]
        public string ImpactCOMPENT{ get; set; }

        /// <summary>
        /// 漏洞影响版本
        /// </summary>
        [JsonProperty("ImpactVersion")]
        public string ImpactVersion{ get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// 漏洞描述
        /// </summary>
        [JsonProperty("VULDescribe")]
        public string VULDescribe{ get; set; }

        /// <summary>
        /// 修复建议
        /// </summary>
        [JsonProperty("Fix")]
        public string Fix{ get; set; }

        /// <summary>
        /// 产品支持状态，实时返回
        /// </summary>
        [JsonProperty("ProSupport")]
        public ulong? ProSupport{ get; set; }

        /// <summary>
        /// 是否公开，0为未发布，1为发布
        /// </summary>
        [JsonProperty("IsPublish")]
        public ulong? IsPublish{ get; set; }

        /// <summary>
        /// 释放时间
        /// </summary>
        [JsonProperty("ReleaseTime")]
        public string ReleaseTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 漏洞子类别
        /// </summary>
        [JsonProperty("SubCategory")]
        public string SubCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "PatchId", this.PatchId);
            this.SetParamSimple(map, prefix + "VULName", this.VULName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "CVSSScore", this.CVSSScore);
            this.SetParamSimple(map, prefix + "CVEId", this.CVEId);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "VULCategory", this.VULCategory);
            this.SetParamSimple(map, prefix + "ImpactOs", this.ImpactOs);
            this.SetParamSimple(map, prefix + "ImpactCOMPENT", this.ImpactCOMPENT);
            this.SetParamSimple(map, prefix + "ImpactVersion", this.ImpactVersion);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "VULDescribe", this.VULDescribe);
            this.SetParamSimple(map, prefix + "Fix", this.Fix);
            this.SetParamSimple(map, prefix + "ProSupport", this.ProSupport);
            this.SetParamSimple(map, prefix + "IsPublish", this.IsPublish);
            this.SetParamSimple(map, prefix + "ReleaseTime", this.ReleaseTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "SubCategory", this.SubCategory);
        }
    }
}

