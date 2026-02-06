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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GovernanceNamespace : AbstractModel
    {
        
        /// <summary>
        /// 命名空间名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 命名空间描述信息。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 命名空间下总服务数据量
        /// </summary>
        [JsonProperty("TotalServiceCount")]
        public long? TotalServiceCount{ get; set; }

        /// <summary>
        /// 命名空间下总健康实例数量
        /// </summary>
        [JsonProperty("TotalHealthInstanceCount")]
        public long? TotalHealthInstanceCount{ get; set; }

        /// <summary>
        /// 命名空间下总实例数量
        /// </summary>
        [JsonProperty("TotalInstanceCount")]
        public long? TotalInstanceCount{ get; set; }

        /// <summary>
        /// 命名空间ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 是否可以编辑
        /// </summary>
        [JsonProperty("Editable")]
        public bool? Editable{ get; set; }

        /// <summary>
        /// 可以操作此命名空间的用户ID列表
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 可以操作此命名空间的用户组ID列表
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// 移除可以操作此命名空间的用户ID列表
        /// </summary>
        [JsonProperty("RemoveUserIds")]
        public string[] RemoveUserIds{ get; set; }

        /// <summary>
        /// 移除可以操作此命名空间的用户组ID列表
        /// </summary>
        [JsonProperty("RemoveGroupIds")]
        public string[] RemoveGroupIds{ get; set; }

        /// <summary>
        /// 该命名空间下的服务对哪些命名空间可见
        /// </summary>
        [JsonProperty("ServiceExportTo")]
        public string[] ServiceExportTo{ get; set; }

        /// <summary>
        /// 是否开启同步到全局注册中心	
        /// </summary>
        [JsonProperty("SyncToGlobalRegistry")]
        public bool? SyncToGlobalRegistry{ get; set; }

        /// <summary>
        /// 元数据
        /// </summary>
        [JsonProperty("Metadatas")]
        public Metadata[] Metadatas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "TotalServiceCount", this.TotalServiceCount);
            this.SetParamSimple(map, prefix + "TotalHealthInstanceCount", this.TotalHealthInstanceCount);
            this.SetParamSimple(map, prefix + "TotalInstanceCount", this.TotalInstanceCount);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Editable", this.Editable);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamArraySimple(map, prefix + "RemoveUserIds.", this.RemoveUserIds);
            this.SetParamArraySimple(map, prefix + "RemoveGroupIds.", this.RemoveGroupIds);
            this.SetParamArraySimple(map, prefix + "ServiceExportTo.", this.ServiceExportTo);
            this.SetParamSimple(map, prefix + "SyncToGlobalRegistry", this.SyncToGlobalRegistry);
            this.SetParamArrayObj(map, prefix + "Metadatas.", this.Metadatas);
        }
    }
}

