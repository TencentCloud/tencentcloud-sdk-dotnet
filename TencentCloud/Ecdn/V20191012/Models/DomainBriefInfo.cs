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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainBriefInfo : AbstractModel
    {
        
        /// <summary>
        /// 域名ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 腾讯云账号ID。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// CDN加速域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 域名CName。
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 域名状态，pending，rejected，processing， online，offline，deleted分别表示审核中，审核未通过，审核通过部署中，已开启，已关闭，已删除。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 域名创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 域名更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 源站配置详情。
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// 域名封禁状态，normal，overdue，quota，malicious，ddos，idle，unlicensed，capping，readonly分别表示 正常，欠费停服，试用客户流量包耗尽，恶意用户，ddos攻击，无流量域名，未备案，带宽封顶，只读
        /// </summary>
        [JsonProperty("Disable")]
        public string Disable{ get; set; }

        /// <summary>
        /// 加速区域，mainland，oversea或global。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 域名锁定状态，normal、global，分别表示未被锁定、全球锁定。
        /// </summary>
        [JsonProperty("Readonly")]
        public string Readonly{ get; set; }

        /// <summary>
        /// 域名标签。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamSimple(map, prefix + "Disable", this.Disable);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Readonly", this.Readonly);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
        }
    }
}

