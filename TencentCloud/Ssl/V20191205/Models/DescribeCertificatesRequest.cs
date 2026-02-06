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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCertificatesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>分页偏移量，从0开始。 默认为0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>每页数量，默认10。最大值1000，如超过1000按1000处理</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>搜索关键词，模糊匹配证书 ID、备注名称、证书域名</p>
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// <p>证书类型：CA = 客户端证书，SVR = 服务器证书。</p>
        /// </summary>
        [JsonProperty("CertificateType")]
        public string CertificateType{ get; set; }

        /// <summary>
        /// <p>项目 ID。</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// <p>默认按照证书申请时间降序； 若传排序则按到期时间排序：DESC = 证书到期时间降序， ASC = 证书到期时间升序。</p>
        /// </summary>
        [JsonProperty("ExpirationSort")]
        public string ExpirationSort{ get; set; }

        /// <summary>
        /// <p>证书状态：0 = 审核中，1 = 已通过，2 = 审核失败，3 = 已过期，4 = 已添加DNS记录，5 = 企业证书，待提交，6 = 订单取消中，7 = 已取消，8 = 已提交资料， 待上传确认函，9 = 证书吊销中，10 = 已吊销，11 = 重颁发中，12 = 待上传吊销确认函，13 = 免费证书待提交资料。14 = 已退款。 15 = 证书迁移中</p>
        /// </summary>
        [JsonProperty("CertificateStatus")]
        public ulong?[] CertificateStatus{ get; set; }

        /// <summary>
        /// <p>是否可部署，可选值：1 = 可部署，0 =  不可部署。</p>
        /// </summary>
        [JsonProperty("Deployable")]
        public ulong? Deployable{ get; set; }

        /// <summary>
        /// <p>是否筛选上传托管的 1筛选，0不筛选</p>
        /// </summary>
        [JsonProperty("Upload")]
        public long? Upload{ get; set; }

        /// <summary>
        /// <p>是否筛选可续期证书 1筛选 0不筛选</p>
        /// </summary>
        [JsonProperty("Renew")]
        public long? Renew{ get; set; }

        /// <summary>
        /// <p>筛选来源， upload：上传证书， buy：腾讯云证书， 不传默认全部</p>
        /// </summary>
        [JsonProperty("FilterSource")]
        public string FilterSource{ get; set; }

        /// <summary>
        /// <p>是否筛选国密证书。1:筛选  0:不筛选</p>
        /// </summary>
        [JsonProperty("IsSM")]
        public long? IsSM{ get; set; }

        /// <summary>
        /// <p>筛选证书是否即将过期，传1是筛选，0不筛选</p>
        /// </summary>
        [JsonProperty("FilterExpiring")]
        public ulong? FilterExpiring{ get; set; }

        /// <summary>
        /// <p>是否可托管，可选值：1 = 可托管，0 =  不可托管。</p>
        /// </summary>
        [JsonProperty("Hostable")]
        public ulong? Hostable{ get; set; }

        /// <summary>
        /// <p>筛选指定标签的证书</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// <p>是否筛选等待签发的证书，传1是筛选，0和null不筛选</p>
        /// </summary>
        [JsonProperty("IsPendingIssue")]
        public long? IsPendingIssue{ get; set; }

        /// <summary>
        /// <p>筛选指定证书ID的证书，只支持有权限的证书ID</p>
        /// </summary>
        [JsonProperty("CertIds")]
        public string[] CertIds{ get; set; }

        /// <summary>
        /// <p>订阅服务ID</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ExpirationSort", this.ExpirationSort);
            this.SetParamArraySimple(map, prefix + "CertificateStatus.", this.CertificateStatus);
            this.SetParamSimple(map, prefix + "Deployable", this.Deployable);
            this.SetParamSimple(map, prefix + "Upload", this.Upload);
            this.SetParamSimple(map, prefix + "Renew", this.Renew);
            this.SetParamSimple(map, prefix + "FilterSource", this.FilterSource);
            this.SetParamSimple(map, prefix + "IsSM", this.IsSM);
            this.SetParamSimple(map, prefix + "FilterExpiring", this.FilterExpiring);
            this.SetParamSimple(map, prefix + "Hostable", this.Hostable);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "IsPendingIssue", this.IsPendingIssue);
            this.SetParamArraySimple(map, prefix + "CertIds.", this.CertIds);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
        }
    }
}

