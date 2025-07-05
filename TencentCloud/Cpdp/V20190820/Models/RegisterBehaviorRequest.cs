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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterBehaviorRequest : AbstractModel
    {
        
        /// <summary>
        /// 聚鑫分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 聚鑫计费SubAppId，代表子商户
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// 按照聚鑫安全密钥计算的签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// 功能标志
        /// 1：登记行为记录信息
        /// 2：查询补录信息
        /// </summary>
        [JsonProperty("FunctionFlag")]
        public long? FunctionFlag{ get; set; }

        /// <summary>
        /// 环境名:
        /// release: 现网环境
        /// sandbox: 沙箱环境
        /// development: 开发环境
        /// 缺省: release
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }

        /// <summary>
        /// 操作点击时间
        /// yyyyMMddHHmmss
        /// 功能标志FunctionFlag=1时必输
        /// </summary>
        [JsonProperty("OperationClickTime")]
        public string OperationClickTime{ get; set; }

        /// <summary>
        /// IP地址
        /// 功能标志FunctionFlag=1时必输
        /// </summary>
        [JsonProperty("IpAddress")]
        public string IpAddress{ get; set; }

        /// <summary>
        /// MAC地址
        /// 功能标志FunctionFlag=1时必输
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// 签约渠道
        /// 1:  App
        /// 2:  平台H5网页
        /// 3：公众号
        /// 4：小程序
        /// 功能标志FunctionFlag=1时必输
        /// </summary>
        [JsonProperty("SignChannel")]
        public long? SignChannel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "FunctionFlag", this.FunctionFlag);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
            this.SetParamSimple(map, prefix + "OperationClickTime", this.OperationClickTime);
            this.SetParamSimple(map, prefix + "IpAddress", this.IpAddress);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "SignChannel", this.SignChannel);
        }
    }
}

