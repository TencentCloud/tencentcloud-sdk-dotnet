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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataAuthorizationInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据委托方、需求方：客户主体名称。
        /// </summary>
        [JsonProperty("DataProviderName")]
        public string DataProviderName{ get; set; }

        /// <summary>
        /// 数据受托方、提供方：腾讯云主体名称。固定填：腾讯云计算（北京）有限责任公司
        /// </summary>
        [JsonProperty("DataRecipientName")]
        public string DataRecipientName{ get; set; }

        /// <summary>
        /// 客户请求RCE所提供的用户数据类型，支持多选。实际以接口请求传参为准。
        /// 1-手机号；
        /// 2-微信开放账号；
        /// 3-QQ开放账号；
        /// 4-IP地址；
        /// 999-其它；
        /// </summary>
        [JsonProperty("UserDataType")]
        public ulong?[] UserDataType{ get; set; }

        /// <summary>
        /// 客户是否已按[合规指南](https://rule.tencent.com/rule/202409130001)要求获取用户授权，同意客户委托腾讯云处理入参信息
        /// 1-已授权；其它值为未授权。
        /// </summary>
        [JsonProperty("IsAuthorize")]
        public ulong? IsAuthorize{ get; set; }

        /// <summary>
        /// 客户是否已按[合规指南](https://rule.tencent.com/rule/202409130001)要求获取用户授权，同意腾讯云结合客户提供的信息，对已合法收集的用户数据进行必要处理得出服务结果，并返回给客户。
        /// 1-已授权；其它值为未授权。
        /// </summary>
        [JsonProperty("IsOrderHandling")]
        public ulong? IsOrderHandling{ get; set; }

        /// <summary>
        /// 客户获得的用户授权期限时间戳（单位秒）。不填默认无固定期限。
        /// </summary>
        [JsonProperty("AuthorizationTerm")]
        public ulong? AuthorizationTerm{ get; set; }

        /// <summary>
        /// 客户获得用户授权所依赖的协议地址。
        /// </summary>
        [JsonProperty("PrivacyPolicyLink")]
        public string PrivacyPolicyLink{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataProviderName", this.DataProviderName);
            this.SetParamSimple(map, prefix + "DataRecipientName", this.DataRecipientName);
            this.SetParamArraySimple(map, prefix + "UserDataType.", this.UserDataType);
            this.SetParamSimple(map, prefix + "IsAuthorize", this.IsAuthorize);
            this.SetParamSimple(map, prefix + "IsOrderHandling", this.IsOrderHandling);
            this.SetParamSimple(map, prefix + "AuthorizationTerm", this.AuthorizationTerm);
            this.SetParamSimple(map, prefix + "PrivacyPolicyLink", this.PrivacyPolicyLink);
        }
    }
}

