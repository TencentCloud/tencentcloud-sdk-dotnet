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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataAuthorization : AbstractModel
    {
        
        /// <summary>
        /// <p>数据委托方，客户主体名称</p>
        /// </summary>
        [JsonProperty("DataProviderName")]
        public string DataProviderName{ get; set; }

        /// <summary>
        /// <p>数据受托方，腾讯云主体名称，固定填：腾讯云计算（北京）有限责任公司</p>
        /// </summary>
        [JsonProperty("DataRecipientName")]
        public string DataRecipientName{ get; set; }

        /// <summary>
        /// <p>客户请求RCE所提供的用户数据类型，支持多选</p><p>枚举值：</p><ul><li>1： 手机号</li><li>2： 微信开放账号</li><li>3： QQ开放账号</li><li>4： IP地址</li><li>5： URL网址</li><li>999： 其他</li></ul>
        /// </summary>
        [JsonProperty("UserDataType")]
        public long?[] UserDataType{ get; set; }

        /// <summary>
        /// <p>客户是否已按合规指南要求获取用户授权，同意客户委托腾讯云处理入参信息</p><p>枚举值：</p><ul><li>true： 已授权</li><li>false： 未授权</li></ul>
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public bool? IsAuthorized{ get; set; }

        /// <summary>
        /// <p>客户是否已按合规指南要求获取用户授权，同意腾讯云结合客户提供的信息，对已合法收集的用户数据进行必要处理得出服务结果，并返回给客户</p><p>枚举值：</p><ul><li>true： 已授权</li><li>false： 未授权</li></ul>
        /// </summary>
        [JsonProperty("IsOrderHanding")]
        public bool? IsOrderHanding{ get; set; }

        /// <summary>
        /// <p>客户获得的用户授权期限Unix时间戳（单位秒），不填默认无固定期限</p>
        /// </summary>
        [JsonProperty("AuthorizationDeadline")]
        public long? AuthorizationDeadline{ get; set; }

        /// <summary>
        /// <p>客户获得用户授权所依赖的协议地址</p>
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
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
            this.SetParamSimple(map, prefix + "IsOrderHanding", this.IsOrderHanding);
            this.SetParamSimple(map, prefix + "AuthorizationDeadline", this.AuthorizationDeadline);
            this.SetParamSimple(map, prefix + "PrivacyPolicyLink", this.PrivacyPolicyLink);
        }
    }
}

