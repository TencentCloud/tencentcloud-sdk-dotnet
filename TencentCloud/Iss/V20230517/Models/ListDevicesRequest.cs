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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 组织ID
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// 是否获取当前层级及子层级的设备列表，默认false
        /// </summary>
        [JsonProperty("IsContainSubLevel")]
        public bool? IsContainSubLevel{ get; set; }

        /// <summary>
        /// 是否包含当前用户已关联的设备，默认false
        /// </summary>
        [JsonProperty("IsContainUser")]
        public bool? IsContainUser{ get; set; }

        /// <summary>
        /// 设备接入协议。1:RTMP，2:GB，3:GW，4:IVCP(私有协议)
        /// </summary>
        [JsonProperty("AccessProtocol")]
        public ulong? AccessProtocol{ get; set; }

        /// <summary>
        /// 设备类型。1:IPC，2:NVR
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 设备状态。0:未注册，1:在线，2:离线，3:禁用	
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 服务节点ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 模糊搜索设备的关键字
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 当前用户Uin
        /// </summary>
        [JsonProperty("CurrentUin")]
        public ulong? CurrentUin{ get; set; }

        /// <summary>
        /// 页码，默认为1。
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页数量，默认为20，单页最大10000条
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "IsContainSubLevel", this.IsContainSubLevel);
            this.SetParamSimple(map, prefix + "IsContainUser", this.IsContainUser);
            this.SetParamSimple(map, prefix + "AccessProtocol", this.AccessProtocol);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "CurrentUin", this.CurrentUin);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

