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

    public class DescribeHostTkeInstanceListRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页偏移量，从0开始。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 每页数量，默认10。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 待部署的证书ID
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 是否查询缓存，1：是； 0：否， 默认为查询缓存，缓存半小时
        /// </summary>
        [JsonProperty("IsCache")]
        public ulong? IsCache{ get; set; }

        /// <summary>
        /// 过滤参数列表； FilterKey：domainMatch（查询域名是否匹配的实例列表） FilterValue：1，表示查询匹配； 0，表示查询不匹配； 默认查询匹配
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 是否异步缓存，0表示否，1表示是，默认为0
        /// </summary>
        [JsonProperty("AsyncCache")]
        public long? AsyncCache{ get; set; }

        /// <summary>
        /// 原证书ID
        /// </summary>
        [JsonProperty("OldCertificateId")]
        public string OldCertificateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "IsCache", this.IsCache);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "AsyncCache", this.AsyncCache);
            this.SetParamSimple(map, prefix + "OldCertificateId", this.OldCertificateId);
        }
    }
}

