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
        /// 管理域实例ID，用于CAM管理域权限分配。若企业未进行管理域的划分，可直接传入根域"1"，此时表示针对当前企业的全部设备和账号进行接口CRUD，具体CRUD的影响范围限制于相应接口的入参。
        /// </summary>
        [JsonProperty("DomainInstanceId")]
        public string DomainInstanceId{ get; set; }

        /// <summary>
        /// 必填，终端自定义分组名
        /// </summary>
        [JsonProperty("DeviceVirtualGroupName")]
        public string DeviceVirtualGroupName{ get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 必填，系统类型（0: win，1：linux，2: mac，3: win_srv，4：android，5：ios ）(只支持32位)
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 必填，分组类型（0:手动分组；非0为自动划分分组；具体枚举值为：1:自动每小时划分分组、2:自动每天划分分组、3:自定义时间划分分组）(只支持32位)
        /// </summary>
        [JsonProperty("TimeType")]
        public long? TimeType{ get; set; }

        /// <summary>
        /// 选填，TimeType=3时的自动划分时间，其他情况为0（单位min）(只支持32位)
        /// </summary>
        [JsonProperty("AutoMinute")]
        public long? AutoMinute{ get; set; }

        /// <summary>
        /// 选填，手动分组不填，自动划分分组的划分规则数据
        /// </summary>
        [JsonProperty("AutoRules")]
        public ComplexRule AutoRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainInstanceId", this.DomainInstanceId);
            this.SetParamSimple(map, prefix + "DeviceVirtualGroupName", this.DeviceVirtualGroupName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "TimeType", this.TimeType);
            this.SetParamSimple(map, prefix + "AutoMinute", this.AutoMinute);
            this.SetParamObj(map, prefix + "AutoRules.", this.AutoRules);
        }
    }
}

