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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDspmCkafkaSaveRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>接入类型，当前支持 1和7</p><p>枚举值：</p><ul><li>1： 外网TGW</li><li>2： 基础网络</li><li>3： VPC网络</li><li>4： idc环境-支撑网络</li><li>5： SSL外网访问方式访问</li><li>6： 黑石环境vpc</li><li>7： cvm环境-支撑网络</li></ul>
        /// </summary>
        [JsonProperty("VipType")]
        public long? VipType{ get; set; }

        /// <summary>
        /// <p>实例的地域</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// <p>实例的id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>实例的接入信息</p>
        /// </summary>
        [JsonProperty("RouteInfo")]
        public RouteInfo RouteInfo{ get; set; }

        /// <summary>
        /// <p>接入为域名的时候，有效</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>接入为域名的时候，有效</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>日志投递的主题配置</p>
        /// </summary>
        [JsonProperty("LogDeliveryInfo")]
        public LogDeliveryInfo[] LogDeliveryInfo{ get; set; }

        /// <summary>
        /// <p>已存在配置时是否覆盖，默认 false（不覆盖，保持兼容）</p>
        /// </summary>
        [JsonProperty("IsOverwrite")]
        public bool? IsOverwrite{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VipType", this.VipType);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "RouteInfo.", this.RouteInfo);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "LogDeliveryInfo.", this.LogDeliveryInfo);
            this.SetParamSimple(map, prefix + "IsOverwrite", this.IsOverwrite);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

