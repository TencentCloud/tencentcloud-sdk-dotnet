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

    public class GovernanceService : AbstractModel
    {
        
        /// <summary>
        /// 服务名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 命名空间名称。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 元数据信息数组。
        /// </summary>
        [JsonProperty("Metadatas")]
        public Metadata[] Metadatas{ get; set; }

        /// <summary>
        /// 描述信息。
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
        /// 服务所属部门。
        /// </summary>
        [JsonProperty("Department")]
        public string Department{ get; set; }

        /// <summary>
        /// 服务所属业务。
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 健康服务实例数
        /// </summary>
        [JsonProperty("HealthyInstanceCount")]
        public ulong? HealthyInstanceCount{ get; set; }

        /// <summary>
        /// 服务实例总数
        /// </summary>
        [JsonProperty("TotalInstanceCount")]
        public ulong? TotalInstanceCount{ get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 是否可以编辑
        /// </summary>
        [JsonProperty("Editable")]
        public bool? Editable{ get; set; }

        /// <summary>
        /// 可以编辑该资源的用户ID
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 可以编辑该资源的用户组ID
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// 移除可以编辑该资源的用户ID
        /// </summary>
        [JsonProperty("RemoveUserIds")]
        public string[] RemoveUserIds{ get; set; }

        /// <summary>
        /// 移除可以编辑该资源的用户组ID
        /// </summary>
        [JsonProperty("RemoveGroupIds")]
        public string[] RemoveGroupIds{ get; set; }

        /// <summary>
        /// 该服务对哪些命名空间可见	
        /// </summary>
        [JsonProperty("ExportTo")]
        public string[] ExportTo{ get; set; }

        /// <summary>
        /// 该服务信息摘要签名
        /// </summary>
        [JsonProperty("Revision")]
        public string Revision{ get; set; }

        /// <summary>
        /// 是否开启同步到全局注册中心
        /// </summary>
        [JsonProperty("SyncToGlobalRegistry")]
        public bool? SyncToGlobalRegistry{ get; set; }

        /// <summary>
        /// 隔离实例数
        /// </summary>
        [JsonProperty("IsolateInstanceCount")]
        public ulong? IsolateInstanceCount{ get; set; }

        /// <summary>
        /// 服务健康状态
        /// </summary>
        [JsonProperty("ServiceStatus")]
        public long? ServiceStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamArrayObj(map, prefix + "Metadatas.", this.Metadatas);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Department", this.Department);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "HealthyInstanceCount", this.HealthyInstanceCount);
            this.SetParamSimple(map, prefix + "TotalInstanceCount", this.TotalInstanceCount);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Editable", this.Editable);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamArraySimple(map, prefix + "RemoveUserIds.", this.RemoveUserIds);
            this.SetParamArraySimple(map, prefix + "RemoveGroupIds.", this.RemoveGroupIds);
            this.SetParamArraySimple(map, prefix + "ExportTo.", this.ExportTo);
            this.SetParamSimple(map, prefix + "Revision", this.Revision);
            this.SetParamSimple(map, prefix + "SyncToGlobalRegistry", this.SyncToGlobalRegistry);
            this.SetParamSimple(map, prefix + "IsolateInstanceCount", this.IsolateInstanceCount);
            this.SetParamSimple(map, prefix + "ServiceStatus", this.ServiceStatus);
        }
    }
}

