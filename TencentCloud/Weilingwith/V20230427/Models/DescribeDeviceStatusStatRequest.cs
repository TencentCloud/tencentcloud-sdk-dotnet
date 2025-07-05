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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceStatusStatRequest : AbstractModel
    {
        
        /// <summary>
        /// 所属空间地理层级，必填。0表示查询所有层级（1、2）的设备状态，1表示楼栋，2表示楼层
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 工作空间id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public long? WorkspaceId{ get; set; }

        /// <summary>
        /// 应用token
        /// </summary>
        [JsonProperty("ApplicationToken")]
        public string ApplicationToken{ get; set; }

        /// <summary>
        /// 空间位置，非必填。为空表示查询所有（1，2）层级
        /// </summary>
        [JsonProperty("SpaceCodeSet")]
        public string[] SpaceCodeSet{ get; set; }

        /// <summary>
        /// 设备类型，非必填。为空表示查询所有设备类型
        /// </summary>
        [JsonProperty("DeviceTypeSet")]
        public string[] DeviceTypeSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "ApplicationToken", this.ApplicationToken);
            this.SetParamArraySimple(map, prefix + "SpaceCodeSet.", this.SpaceCodeSet);
            this.SetParamArraySimple(map, prefix + "DeviceTypeSet.", this.DeviceTypeSet);
        }
    }
}

