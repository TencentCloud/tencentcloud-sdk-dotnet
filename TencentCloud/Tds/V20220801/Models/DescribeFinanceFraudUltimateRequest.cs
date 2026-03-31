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

namespace TencentCloud.Tds.V20220801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFinanceFraudUltimateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>客户端通过SDK获取的设备Token</p>
        /// </summary>
        [JsonProperty("DeviceToken")]
        public string DeviceToken{ get; set; }

        /// <summary>
        /// <p>使用场景。目前仅支持login-登录场景、register-注册场景</p>
        /// </summary>
        [JsonProperty("SceneCode")]
        public string SceneCode{ get; set; }

        /// <summary>
        /// <p>用户唯一标识</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>事件时间戳（毫秒）</p>
        /// </summary>
        [JsonProperty("EventTime")]
        public ulong? EventTime{ get; set; }

        /// <summary>
        /// <p>事件耗时（毫秒），例如进入登录界面到点击登录按钮耗时</p>
        /// </summary>
        [JsonProperty("ElapsedTime")]
        public ulong? ElapsedTime{ get; set; }

        /// <summary>
        /// <p>微信的OpenId</p>
        /// </summary>
        [JsonProperty("WeChatOpenId")]
        public string WeChatOpenId{ get; set; }

        /// <summary>
        /// <p>手机号码（注：不需要带国家代码 例如：13430421011）。可以传入原文或MD5</p>
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// <p>业务客户端IP</p>
        /// </summary>
        [JsonProperty("BizClientIp")]
        public string BizClientIp{ get; set; }

        /// <summary>
        /// <p>QQ的OpenId</p>
        /// </summary>
        [JsonProperty("QQOpenId")]
        public string QQOpenId{ get; set; }

        /// <summary>
        /// <p>数据授权信息</p>
        /// </summary>
        [JsonProperty("DataAuthorization")]
        public DataAuthorizationInfo DataAuthorization{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceToken", this.DeviceToken);
            this.SetParamSimple(map, prefix + "SceneCode", this.SceneCode);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "ElapsedTime", this.ElapsedTime);
            this.SetParamSimple(map, prefix + "WeChatOpenId", this.WeChatOpenId);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "BizClientIp", this.BizClientIp);
            this.SetParamSimple(map, prefix + "QQOpenId", this.QQOpenId);
            this.SetParamObj(map, prefix + "DataAuthorization.", this.DataAuthorization);
        }
    }
}

