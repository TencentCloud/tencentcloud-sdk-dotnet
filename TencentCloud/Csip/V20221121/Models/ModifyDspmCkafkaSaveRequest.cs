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
        /// 接入类型，当前支持 1和7, 类型vip网络类型（1:外网TGW 2:基础网络 3:VPC网络 4:支撑网络(idc 环境) 5:SSL外网访问方式访问 6:黑石环境vpc 7:支撑网络(cvm 环境）
        /// </summary>
        [JsonProperty("VipType")]
        public long? VipType{ get; set; }

        /// <summary>
        /// 实例的地域
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// 实例的id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例的接入信息
        /// </summary>
        [JsonProperty("RouteInfo")]
        public RouteInfo RouteInfo{ get; set; }

        /// <summary>
        /// 接入为域名的时候，有效
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 接入为域名的时候，有效
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 日志投递的主题配置
        /// </summary>
        [JsonProperty("LogDeliveryInfo")]
        public LogDeliveryInfo[] LogDeliveryInfo{ get; set; }

        /// <summary>
        /// 已存在配置时是否覆盖，默认 false（不覆盖，保持兼容）
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

