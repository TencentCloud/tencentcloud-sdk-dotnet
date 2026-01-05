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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowPermission : AbstractModel
    {
        
        /// <summary>
        /// 授权目标类型（用户：user，角色：role）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PermissionTargetType")]
        public string PermissionTargetType{ get; set; }

        /// <summary>
        /// 授权目标id数组(userId/roleId)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PermissionTargetId")]
        public string PermissionTargetId{ get; set; }

        /// <summary>
        /// 授权权限类型数组(CAN_VIEW/CAN_RUN/CAN_EDIT/CAN_MANAGE，当前仅支持CAN_MANAGE)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PermissionTypeList")]
        public string[] PermissionTypeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PermissionTargetType", this.PermissionTargetType);
            this.SetParamSimple(map, prefix + "PermissionTargetId", this.PermissionTargetId);
            this.SetParamArraySimple(map, prefix + "PermissionTypeList.", this.PermissionTypeList);
        }
    }
}

