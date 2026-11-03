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

    public class ModifyCSRRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>CSR ID标识</p>
        /// </summary>
        [JsonProperty("CSRId")]
        public long? CSRId{ get; set; }

        /// <summary>
        /// <p>是否生成CSR内容。生成CSR内容后，此CSR记录不再支持修改</p>
        /// </summary>
        [JsonProperty("Generate")]
        public bool? Generate{ get; set; }

        /// <summary>
        /// <p>域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>企业/单位名称</p>
        /// </summary>
        [JsonProperty("Organization")]
        public string Organization{ get; set; }

        /// <summary>
        /// <p>部门</p>
        /// </summary>
        [JsonProperty("Department")]
        public string Department{ get; set; }

        /// <summary>
        /// <p>邮箱</p>
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// <p>省份</p>
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// <p>城市</p>
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// <p>国家</p>
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// <p>加密算法，支持 RSA及ECC。</p>
        /// </summary>
        [JsonProperty("EncryptAlgo")]
        public string EncryptAlgo{ get; set; }

        /// <summary>
        /// <p>密钥参数，RSA仅支持2048，4096。ECC仅支持prime256v1</p>
        /// </summary>
        [JsonProperty("KeyParameter")]
        public string KeyParameter{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>私钥密码</p>
        /// </summary>
        [JsonProperty("KeyPassword")]
        public string KeyPassword{ get; set; }

        /// <summary>
        /// <p>SAN域名</p>
        /// </summary>
        [JsonProperty("SubjectAltName")]
        public string[] SubjectAltName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CSRId", this.CSRId);
            this.SetParamSimple(map, prefix + "Generate", this.Generate);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Organization", this.Organization);
            this.SetParamSimple(map, prefix + "Department", this.Department);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "EncryptAlgo", this.EncryptAlgo);
            this.SetParamSimple(map, prefix + "KeyParameter", this.KeyParameter);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "KeyPassword", this.KeyPassword);
            this.SetParamArraySimple(map, prefix + "SubjectAltName.", this.SubjectAltName);
        }
    }
}

