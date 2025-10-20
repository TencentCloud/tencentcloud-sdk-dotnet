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

    public class ExportDeviceDownloadTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 系统类型（0: win，1：linux，2: mac，4：android，5：ios；默认值0）
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 管理域实例ID，用于CAM管理域权限分配。若企业未进行管理域的划分，可直接传入根域"1"，此时表示针对当前企业的全部设备和账号进行接口CRUD，具体CRUD的影响范围限制于相应接口的入参。
        /// </summary>
        [JsonProperty("DomainInstanceId")]
        public string DomainInstanceId{ get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        ///  在线状态 2 在线 0，1 离线
        /// </summary>
        [JsonProperty("OnlineStatus")]
        public long? OnlineStatus{ get; set; }

        /// <summary>
        /// 导出顺序，接口返回的数据字段
        /// </summary>
        [JsonProperty("ExportOrder")]
        public string ExportOrder{ get; set; }

        /// <summary>
        ///  导出类型， 0：终端树；7:硬件信息列表导出；
        /// </summary>
        [JsonProperty("ExportType")]
        public long? ExportType{ get; set; }

        /// <summary>
        /// 过滤条件。同DescribeDevices接口
        /// </summary>
        [JsonProperty("Condition")]
        public Condition Condition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "DomainInstanceId", this.DomainInstanceId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "OnlineStatus", this.OnlineStatus);
            this.SetParamSimple(map, prefix + "ExportOrder", this.ExportOrder);
            this.SetParamSimple(map, prefix + "ExportType", this.ExportType);
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
        }
    }
}

