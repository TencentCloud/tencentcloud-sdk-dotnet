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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 资源组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 资源组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// 资源组状态
        /// COMPUTE_RESOURCE_STATUS_UNSPECIFIED 未指定
        /// COMPUTE_RESOURCE_STATUS_PENDING_CREATE 待创建
        /// COMPUTE_RESOURCE_STATUS_CREATING 创建中
        /// COMPUTE_RESOURCE_STATUS_RUNNING 运行中
        /// COMPUTE_RESOURCE_STATUS_STOPPED 已停止
        /// COMPUTE_RESOURCE_STATUS_STOPPING 停止中
        /// COMPUTE_RESOURCE_STATUS_STARTING 启动中
        /// COMPUTE_RESOURCE_STATUS_UPDATING 更新中
        /// COMPUTE_RESOURCE_STATUS_DELETING 删除中
        /// COMPUTE_RESOURCE_STATUS_DELETED 已删除
        /// COMPUTE_RESOURCE_STATUS_FAILED  失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupStatus")]
        public string ResourceGroupStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamSimple(map, prefix + "ResourceGroupStatus", this.ResourceGroupStatus);
        }
    }
}

