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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfsFileSystemsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>文件系统 ID</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>私有网络（VPC） ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网 ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Offset 分页码,默认0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Limit 页面大小，默认10</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>用户自定义名称</p>
        /// </summary>
        [JsonProperty("CreationToken")]
        public string CreationToken{ get; set; }

        /// <summary>
        /// <p>过滤条件。<br><br><li>Protocol - Array of String - 是否必填：否 -（过滤条件）按协议过滤。(NFS | CIFS | TURBO) </li><br><br><li>StorageType - Array of String - 是否必填：否 -（过滤条件）按存储类型过滤。(SD | HP | TB | TP | THP) </li><br><br><li>LifeCycleState - Array of String - 是否必填：否 -（过滤条件）按生命周期过滤。(creating | create_failed | available | deleting | delete_failed | upgrading | unserviced | expanding) </li><br><br><li>Zone - Array of String - 是否必填：否 -（过滤条件）按可用区过滤。(例如：ap-guangzhou-3) </li><br><br><li>IpAddress - Array of String - 是否必填：否 -（过滤条件）按导出点IP地址过滤。(例如：10.0.0.3) </li><br><br><li>PGroupId - Array of String - 是否必填：否 -（过滤条件）按权限组ID过滤。(例如：pgroup-xxxxxrxt) </li><br><br><li>PGroupName - Array of String - 是否必填：否 -（过滤条件）按权限组名称过滤。(例如：默认权限组) </li><br><br><li>Scenario- Array of String - 是否必填：否 -（过滤条件）按权限组名称过滤。(例如：AgentSandbox) </li></p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "CreationToken", this.CreationToken);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

