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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceListRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作空间id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public long? WorkspaceId{ get; set; }

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
        /// 应用token
        /// </summary>
        [JsonProperty("ApplicationToken")]
        public string ApplicationToken{ get; set; }

        /// <summary>
        /// 设备类型，非必填
        /// </summary>
        [JsonProperty("DeviceTypeSet")]
        public string[] DeviceTypeSet{ get; set; }

        /// <summary>
        /// 产品 pid，非必填
        /// </summary>
        [JsonProperty("ProductIdSet")]
        public long?[] ProductIdSet{ get; set; }

        /// <summary>
        /// 设备标签，非必填
        /// </summary>
        [JsonProperty("TagIdSet")]
        public long?[] TagIdSet{ get; set; }

        /// <summary>
        /// 空间层级
        /// </summary>
        [JsonProperty("SpaceCodeSet")]
        public string[] SpaceCodeSet{ get; set; }

        /// <summary>
        /// 设备标签名，非必填
        /// </summary>
        [JsonProperty("DeviceTagSet")]
        public string[] DeviceTagSet{ get; set; }

        /// <summary>
        /// 设备wid,非必填
        /// </summary>
        [JsonProperty("WIDSet")]
        public string[] WIDSet{ get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("Field")]
        public CustomField Field{ get; set; }

        /// <summary>
        /// 分组id列表，非必填
        /// </summary>
        [JsonProperty("GroupIdSet")]
        public long?[] GroupIdSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ApplicationToken", this.ApplicationToken);
            this.SetParamArraySimple(map, prefix + "DeviceTypeSet.", this.DeviceTypeSet);
            this.SetParamArraySimple(map, prefix + "ProductIdSet.", this.ProductIdSet);
            this.SetParamArraySimple(map, prefix + "TagIdSet.", this.TagIdSet);
            this.SetParamArraySimple(map, prefix + "SpaceCodeSet.", this.SpaceCodeSet);
            this.SetParamArraySimple(map, prefix + "DeviceTagSet.", this.DeviceTagSet);
            this.SetParamArraySimple(map, prefix + "WIDSet.", this.WIDSet);
            this.SetParamObj(map, prefix + "Field.", this.Field);
            this.SetParamArraySimple(map, prefix + "GroupIdSet.", this.GroupIdSet);
        }
    }
}

