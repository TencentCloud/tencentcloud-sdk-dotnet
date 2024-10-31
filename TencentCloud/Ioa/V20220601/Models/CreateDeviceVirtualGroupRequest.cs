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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDeviceVirtualGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 终端自定义分组名
        /// </summary>
        [JsonProperty("DeviceVirtualGroupName")]
        public string DeviceVirtualGroupName{ get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 系统类型（0: win，1：linux，2: mac，3: win_srv，4：android，5：ios   默认值0）(只支持32位)
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 时间设置类型（1:自动小时、2:自动每天、3:自定义、0:手动分组）(只支持32位)
        /// </summary>
        [JsonProperty("TimeType")]
        public long? TimeType{ get; set; }

        /// <summary>
        /// 自动划分时间（单位min）(只支持32位)
        /// </summary>
        [JsonProperty("AutoMinute")]
        public long? AutoMinute{ get; set; }

        /// <summary>
        /// 自动划分规则数据
        /// </summary>
        [JsonProperty("AutoRules")]
        public ComplexRule AutoRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceVirtualGroupName", this.DeviceVirtualGroupName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "TimeType", this.TimeType);
            this.SetParamSimple(map, prefix + "AutoMinute", this.AutoMinute);
            this.SetParamObj(map, prefix + "AutoRules.", this.AutoRules);
        }
    }
}

