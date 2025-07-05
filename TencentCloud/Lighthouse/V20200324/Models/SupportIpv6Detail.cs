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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SupportIpv6Detail : AbstractModel
    {
        
        /// <summary>
        /// 是否支持开启IPv6。
        /// </summary>
        [JsonProperty("IsSupport")]
        public bool? IsSupport{ get; set; }

        /// <summary>
        /// 详情。
        /// 
        /// 当IsSupport为True，Detail枚举值为:
        /// 
        /// EFFECTIVE_IMMEDIATELY: 立即生效
        /// 
        /// EFFECTIVE_AFTER_REBOOT: 分配过程需要开关机，用户需备份数据
        /// 
        ///  
        /// 
        /// 当IsSupport为False，Detail枚举值为:
        /// 
        /// HAD_BEEN_ASSIGNED: 已分配IPv6地址
        /// 
        /// REGION_NOT_SUPPORT: 地域不支持
        /// 
        /// BLUEPRINT_NOT_SUPPORT: 镜像不支持
        /// 
        /// BUNDLE_INSTANCE_NOT_SUPPORT: 套餐实例不支持
        /// 
        /// BUNDLE_BANDWIDTH_NOT_SUPPORT: 套餐带宽不支持
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 提示信息。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsSupport", this.IsSupport);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

