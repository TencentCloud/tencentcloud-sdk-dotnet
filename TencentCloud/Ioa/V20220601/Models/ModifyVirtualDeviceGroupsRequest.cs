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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVirtualDeviceGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 必填，操作的设备列表数据
        /// </summary>
        [JsonProperty("DeviceList")]
        public ModifyVirtualDeviceGroupsReqItem[] DeviceList{ get; set; }

        /// <summary>
        /// 管理域实例ID，用于CAM管理域权限分配。若企业未进行管理域的划分，可直接传入根域"1"，此时表示针对当前企业的全部设备和账号进行接口CRUD，具体CRUD的影响范围限制于相应接口的入参。
        /// </summary>
        [JsonProperty("DomainInstanceId")]
        public string DomainInstanceId{ get; set; }

        /// <summary>
        /// 添加到的终端自定义分组id。和DeviceVirtualGroupIds互斥，必填其一，优先使用本参数
        /// </summary>
        [JsonProperty("DeviceVirtualGroupId")]
        public long? DeviceVirtualGroupId{ get; set; }

        /// <summary>
        /// 要添加的终端自定义分组id列表
        /// </summary>
        [JsonProperty("DeviceVirtualGroupIds")]
        public long?[] DeviceVirtualGroupIds{ get; set; }

        /// <summary>
        /// 系统类型（0: win，1：linux，2: mac，4：android，5：ios   默认值0）
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DeviceList.", this.DeviceList);
            this.SetParamSimple(map, prefix + "DomainInstanceId", this.DomainInstanceId);
            this.SetParamSimple(map, prefix + "DeviceVirtualGroupId", this.DeviceVirtualGroupId);
            this.SetParamArraySimple(map, prefix + "DeviceVirtualGroupIds.", this.DeviceVirtualGroupIds);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
        }
    }
}

