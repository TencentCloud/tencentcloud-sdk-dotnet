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

    public class DescribeDeviceStatusListRequest : AbstractModel
    {
        
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
        /// 分页查询，第几页，必传，大于0
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页条数，必传大于0
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("DeviceTypeSet")]
        public string[] DeviceTypeSet{ get; set; }

        /// <summary>
        /// 产品 pid
        /// </summary>
        [JsonProperty("ProductIdSet")]
        public long?[] ProductIdSet{ get; set; }

        /// <summary>
        /// 设备标签id
        /// </summary>
        [JsonProperty("TagIdSet")]
        public long?[] TagIdSet{ get; set; }

        /// <summary>
        /// 空间位置（支持空间多层，比如具体建筑、具体楼层）
        /// </summary>
        [JsonProperty("SpaceCodeSet")]
        public string[] SpaceCodeSet{ get; set; }

        /// <summary>
        /// 设备编号列表
        /// </summary>
        [JsonProperty("WIDSet")]
        public string[] WIDSet{ get; set; }

        /// <summary>
        /// 设备标签名，非必填
        /// </summary>
        [JsonProperty("DeviceTagSet")]
        public string[] DeviceTagSet{ get; set; }

        /// <summary>
        /// 通信在/离线状态（online=normal+fault、offline）
        /// </summary>
        [JsonProperty("DeviceStatusSet")]
        public string[] DeviceStatusSet{ get; set; }

        /// <summary>
        /// 设备业务状态
        /// （正常-normal、故障-fault、离线-offline）
        /// </summary>
        [JsonProperty("StatusSet")]
        public string[] StatusSet{ get; set; }

        /// <summary>
        /// 推流状态，推流中-true，未推流-false 仅摄像头有的状态
        /// </summary>
        [JsonProperty("IsAlive")]
        public bool?[] IsAlive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "ApplicationToken", this.ApplicationToken);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "DeviceTypeSet.", this.DeviceTypeSet);
            this.SetParamArraySimple(map, prefix + "ProductIdSet.", this.ProductIdSet);
            this.SetParamArraySimple(map, prefix + "TagIdSet.", this.TagIdSet);
            this.SetParamArraySimple(map, prefix + "SpaceCodeSet.", this.SpaceCodeSet);
            this.SetParamArraySimple(map, prefix + "WIDSet.", this.WIDSet);
            this.SetParamArraySimple(map, prefix + "DeviceTagSet.", this.DeviceTagSet);
            this.SetParamArraySimple(map, prefix + "DeviceStatusSet.", this.DeviceStatusSet);
            this.SetParamArraySimple(map, prefix + "StatusSet.", this.StatusSet);
            this.SetParamArraySimple(map, prefix + "IsAlive.", this.IsAlive);
        }
    }
}

