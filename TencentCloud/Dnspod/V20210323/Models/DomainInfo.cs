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

    public class DomainInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>域名ID</p>
        /// </summary>
        [JsonProperty("DomainId")]
        public ulong? DomainId{ get; set; }

        /// <summary>
        /// <p>域名状态，正常：ENABLE，暂停：PAUSE，封禁：SPAM</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>域名套餐等级</p>
        /// </summary>
        [JsonProperty("Grade")]
        public string Grade{ get; set; }

        /// <summary>
        /// <p>域名分组ID</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public ulong? GroupId{ get; set; }

        /// <summary>
        /// <p>是否星标域名</p>
        /// </summary>
        [JsonProperty("IsMark")]
        public string IsMark{ get; set; }

        /// <summary>
        /// <p>TTL(DNS记录缓存时间)，单位：秒</p>
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }

        /// <summary>
        /// <p>CNAME加速启用状态</p>
        /// </summary>
        [JsonProperty("CnameSpeedup")]
        [System.Obsolete]
        public string CnameSpeedup{ get; set; }

        /// <summary>
        /// <p>域名备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>域名Punycode</p>
        /// </summary>
        [JsonProperty("Punycode")]
        public string Punycode{ get; set; }

        /// <summary>
        /// <p>域名DNS状态，错误：dnserror，正常：空字符串</p>
        /// </summary>
        [JsonProperty("DnsStatus")]
        [System.Obsolete]
        public string DnsStatus{ get; set; }

        /// <summary>
        /// <p>域名的NS列表</p>
        /// </summary>
        [JsonProperty("DnspodNsList")]
        public string[] DnspodNsList{ get; set; }

        /// <summary>
        /// <p>域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>域名等级代号</p>
        /// </summary>
        [JsonProperty("GradeLevel")]
        public ulong? GradeLevel{ get; set; }

        /// <summary>
        /// <p>域名所属的用户ID</p>
        /// </summary>
        [JsonProperty("UserId")]
        public ulong? UserId{ get; set; }

        /// <summary>
        /// <p>是否为付费域名</p>
        /// </summary>
        [JsonProperty("IsVip")]
        public string IsVip{ get; set; }

        /// <summary>
        /// <p>域名所有者的账号</p>
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// <p>域名等级的描述</p>
        /// </summary>
        [JsonProperty("GradeTitle")]
        public string GradeTitle{ get; set; }

        /// <summary>
        /// <p>域名创建时间</p>
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// <p>最后操作时间</p>
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// <p>腾讯云账户Uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>域名实际使用的NS列表</p>
        /// </summary>
        [JsonProperty("ActualNsList")]
        public string[] ActualNsList{ get; set; }

        /// <summary>
        /// <p>域名的记录数量</p>
        /// </summary>
        [JsonProperty("RecordCount")]
        public ulong? RecordCount{ get; set; }

        /// <summary>
        /// <p>域名所有者的账户昵称</p>
        /// </summary>
        [JsonProperty("OwnerNick")]
        public string OwnerNick{ get; set; }

        /// <summary>
        /// <p>是否在付费套餐宽限期</p>
        /// </summary>
        [JsonProperty("IsGracePeriod")]
        public string IsGracePeriod{ get; set; }

        /// <summary>
        /// <p>是否在付费套餐缓冲期</p>
        /// </summary>
        [JsonProperty("VipBuffered")]
        public string VipBuffered{ get; set; }

        /// <summary>
        /// <p>VIP套餐有效期开始时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VipStartAt")]
        public string VipStartAt{ get; set; }

        /// <summary>
        /// <p>VIP套餐有效期结束时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VipEndAt")]
        public string VipEndAt{ get; set; }

        /// <summary>
        /// <p>VIP套餐自动续费标识。可能的值为：default-默认；no-不自动续费；yes-自动续费</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VipAutoRenew")]
        public string VipAutoRenew{ get; set; }

        /// <summary>
        /// <p>VIP套餐资源ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VipResourceId")]
        public string VipResourceId{ get; set; }

        /// <summary>
        /// <p>是否是子域名。</p>
        /// </summary>
        [JsonProperty("IsSubDomain")]
        public bool? IsSubDomain{ get; set; }

        /// <summary>
        /// <p>域名关联的标签列表</p>
        /// </summary>
        [JsonProperty("TagList")]
        public TagItem[] TagList{ get; set; }

        /// <summary>
        /// <p>是否启用搜索引擎推送</p>
        /// </summary>
        [JsonProperty("SearchEnginePush")]
        public string SearchEnginePush{ get; set; }

        /// <summary>
        /// <p>是否开启辅助 DNS</p>
        /// </summary>
        [JsonProperty("SlaveDNS")]
        public string SlaveDNS{ get; set; }

        /// <summary>
        /// <p>域名DNS状态，错误：dnserror，正常：空字符串</p>
        /// </summary>
        [JsonProperty("DNSStatus")]
        public string DNSStatus{ get; set; }

        /// <summary>
        /// <p>CNAME加速启用状态</p>
        /// </summary>
        [JsonProperty("CNAMESpeedup")]
        public string CNAMESpeedup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Grade", this.Grade);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "IsMark", this.IsMark);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "CnameSpeedup", this.CnameSpeedup);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Punycode", this.Punycode);
            this.SetParamSimple(map, prefix + "DnsStatus", this.DnsStatus);
            this.SetParamArraySimple(map, prefix + "DnspodNsList.", this.DnspodNsList);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "GradeLevel", this.GradeLevel);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "GradeTitle", this.GradeTitle);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamArraySimple(map, prefix + "ActualNsList.", this.ActualNsList);
            this.SetParamSimple(map, prefix + "RecordCount", this.RecordCount);
            this.SetParamSimple(map, prefix + "OwnerNick", this.OwnerNick);
            this.SetParamSimple(map, prefix + "IsGracePeriod", this.IsGracePeriod);
            this.SetParamSimple(map, prefix + "VipBuffered", this.VipBuffered);
            this.SetParamSimple(map, prefix + "VipStartAt", this.VipStartAt);
            this.SetParamSimple(map, prefix + "VipEndAt", this.VipEndAt);
            this.SetParamSimple(map, prefix + "VipAutoRenew", this.VipAutoRenew);
            this.SetParamSimple(map, prefix + "VipResourceId", this.VipResourceId);
            this.SetParamSimple(map, prefix + "IsSubDomain", this.IsSubDomain);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "SearchEnginePush", this.SearchEnginePush);
            this.SetParamSimple(map, prefix + "SlaveDNS", this.SlaveDNS);
            this.SetParamSimple(map, prefix + "DNSStatus", this.DNSStatus);
            this.SetParamSimple(map, prefix + "CNAMESpeedup", this.CNAMESpeedup);
        }
    }
}

