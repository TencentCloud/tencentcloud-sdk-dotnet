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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCertificatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页偏移量，从0开始。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 每页数量，默认20。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 搜索关键词，可搜索证书 ID、备注名称、域名。例如： a8xHcaIs。
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// 证书类型：CA = 客户端证书，SVR = 服务器证书。
        /// </summary>
        [JsonProperty("CertificateType")]
        public string CertificateType{ get; set; }

        /// <summary>
        /// 项目 ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 按到期时间排序：DESC = 降序， ASC = 升序。
        /// </summary>
        [JsonProperty("ExpirationSort")]
        public string ExpirationSort{ get; set; }

        /// <summary>
        /// 证书状态。
        /// </summary>
        [JsonProperty("CertificateStatus")]
        public ulong?[] CertificateStatus{ get; set; }

        /// <summary>
        /// 是否可部署，可选值：1 = 可部署，0 =  不可部署。
        /// </summary>
        [JsonProperty("Deployable")]
        public ulong? Deployable{ get; set; }

        /// <summary>
        /// 是否筛选上传托管的 1筛选，0不筛选
        /// </summary>
        [JsonProperty("Upload")]
        public long? Upload{ get; set; }

        /// <summary>
        /// 是否筛选可续期证书 1筛选 0不筛选
        /// </summary>
        [JsonProperty("Renew")]
        public long? Renew{ get; set; }


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
        }
    }
}

