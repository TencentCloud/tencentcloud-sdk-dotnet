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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBPCompanyInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        [JsonProperty("LicenseName")]
        public string LicenseName{ get; set; }

        /// <summary>
        /// 营业执照审核状态 1-审核中 2-审核未通过，3、审核通过
        /// </summary>
        [JsonProperty("LicenseStatus")]
        public long? LicenseStatus{ get; set; }

        /// <summary>
        /// 营业执照备注
        /// </summary>
        [JsonProperty("LicenseNote")]
        public string LicenseNote{ get; set; }

        /// <summary>
        /// 授权书
        /// </summary>
        [JsonProperty("AuthorizationName")]
        public string AuthorizationName{ get; set; }

        /// <summary>
        /// 授权书审核状态
        /// </summary>
        [JsonProperty("AuthorizationStatus")]
        public long? AuthorizationStatus{ get; set; }

        /// <summary>
        /// 授权书备注
        /// </summary>
        [JsonProperty("AuthorizationNote")]
        public string AuthorizationNote{ get; set; }

        /// <summary>
        /// 品牌信息
        /// </summary>
        [JsonProperty("BrandDatas")]
        public BrandData[] BrandDatas{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public long? CompanyId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "LicenseName", this.LicenseName);
            this.SetParamSimple(map, prefix + "LicenseStatus", this.LicenseStatus);
            this.SetParamSimple(map, prefix + "LicenseNote", this.LicenseNote);
            this.SetParamSimple(map, prefix + "AuthorizationName", this.AuthorizationName);
            this.SetParamSimple(map, prefix + "AuthorizationStatus", this.AuthorizationStatus);
            this.SetParamSimple(map, prefix + "AuthorizationNote", this.AuthorizationNote);
            this.SetParamArrayObj(map, prefix + "BrandDatas.", this.BrandDatas);
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

