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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PackageListItem : AbstractModel
    {
        
        /// <summary>
        /// 域名ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainId")]
        public ulong? DomainId{ get; set; }

        /// <summary>
        /// 域名的原始格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 套餐等级代码
        /// </summary>
        [JsonProperty("Grade")]
        public string Grade{ get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        [JsonProperty("GradeTitle")]
        public string GradeTitle{ get; set; }

        /// <summary>
        /// 付费套餐开通时间
        /// </summary>
        [JsonProperty("VipStartAt")]
        public string VipStartAt{ get; set; }

        /// <summary>
        /// 付费套餐到期时间
        /// </summary>
        [JsonProperty("VipEndAt")]
        public string VipEndAt{ get; set; }

        /// <summary>
        /// 域名是否开通VIP自动续费，是：YES，否：NO，默认：DEFAULT
        /// </summary>
        [JsonProperty("VipAutoRenew")]
        public string VipAutoRenew{ get; set; }

        /// <summary>
        /// 套餐剩余换绑/绑定域名次数
        /// </summary>
        [JsonProperty("RemainTimes")]
        public ulong? RemainTimes{ get; set; }

        /// <summary>
        /// 套餐资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 域名等级代号
        /// </summary>
        [JsonProperty("GradeLevel")]
        public ulong? GradeLevel{ get; set; }

        /// <summary>
        /// 套餐绑定的域名的状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 套餐是否处于宽限期
        /// </summary>
        [JsonProperty("IsGracePeriod")]
        public string IsGracePeriod{ get; set; }

        /// <summary>
        /// 是否降级
        /// </summary>
        [JsonProperty("Downgrade")]
        public bool? Downgrade{ get; set; }

        /// <summary>
        /// 关联安全防护信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityInfo")]
        public SecurityInfo SecurityInfo{ get; set; }

        /// <summary>
        /// 套餐绑定的域名是否为子域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSubDomain")]
        public bool? IsSubDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Grade", this.Grade);
            this.SetParamSimple(map, prefix + "GradeTitle", this.GradeTitle);
            this.SetParamSimple(map, prefix + "VipStartAt", this.VipStartAt);
            this.SetParamSimple(map, prefix + "VipEndAt", this.VipEndAt);
            this.SetParamSimple(map, prefix + "VipAutoRenew", this.VipAutoRenew);
            this.SetParamSimple(map, prefix + "RemainTimes", this.RemainTimes);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "GradeLevel", this.GradeLevel);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsGracePeriod", this.IsGracePeriod);
            this.SetParamSimple(map, prefix + "Downgrade", this.Downgrade);
            this.SetParamObj(map, prefix + "SecurityInfo.", this.SecurityInfo);
            this.SetParamSimple(map, prefix + "IsSubDomain", this.IsSubDomain);
        }
    }
}

