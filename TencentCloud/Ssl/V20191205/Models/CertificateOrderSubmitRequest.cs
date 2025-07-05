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

    public class CertificateOrderSubmitRequest : AbstractModel
    {
        
        /// <summary>
        /// 待提交资料的付费证书 ID。	
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 是否删除自动DNS验证值：0，不删除； 1，删除； 默认不删除
        /// </summary>
        [JsonProperty("DeleteDnsAutoRecord")]
        public ulong? DeleteDnsAutoRecord{ get; set; }

        /// <summary>
        /// 证书域名验证方式：
        /// DNS_AUTO： 自动添加域名DNS验证， 需用户域名解析托管在『[云解析DNS](https://console.cloud.tencent.com/cns)』，且与申请证书归属同一个腾讯云账号
        /// DNS：手动添加域名DNS验证，需用户手动去域名解析服务商添加验证值
        /// FILE：手动添加域名文件验证。 需要用户手动在域名站点根目录添加指定路径文件进行文件验证， http&https任一通过即可；且域名站点需海外CA机构能访问， 具体访问白名单见控制台页面
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "DeleteDnsAutoRecord", this.DeleteDnsAutoRecord);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
        }
    }
}

