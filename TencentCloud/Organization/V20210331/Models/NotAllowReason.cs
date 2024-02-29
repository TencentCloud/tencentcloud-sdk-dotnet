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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NotAllowReason : AbstractModel
    {
        
        /// <summary>
        /// 是否创建的成员。true-是、false-否；成员不是创建的成员不允许删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsCreateMember")]
        public bool? IsCreateMember{ get; set; }

        /// <summary>
        /// 成员删除许可。true-开启、false-关闭；成员删除许可关闭时不允许删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeletionPermission")]
        public bool? DeletionPermission{ get; set; }

        /// <summary>
        /// 是否可信服务委派管理员。true-是、false-否；成员是可信服务委派管理员不允许删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAssignManager")]
        public bool? IsAssignManager{ get; set; }

        /// <summary>
        /// 是否主体管理员。true-是、false-否；成员是主体管理员不允许删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAuthManager")]
        public bool? IsAuthManager{ get; set; }

        /// <summary>
        /// 是否共享资源管理员。true-是、false-否；成员是共享资源管理员不允许删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsShareManager")]
        public bool? IsShareManager{ get; set; }

        /// <summary>
        /// 成员是否设置了操作审批。true-是、false-否；成员设置了操作审批时不允许删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateProcess")]
        public bool? OperateProcess{ get; set; }

        /// <summary>
        /// 是否允许解除成员财务权限。true-是、false-否；成员不能解除财务权限时不允许删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingPermission")]
        public bool? BillingPermission{ get; set; }

        /// <summary>
        /// 存在的资源列表。账号存在资源时不允许删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExistResources")]
        public string[] ExistResources{ get; set; }

        /// <summary>
        /// 检测失败的资源列表。账号有资源检测失败时不允许删除。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectFailedResources")]
        public string[] DetectFailedResources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsCreateMember", this.IsCreateMember);
            this.SetParamSimple(map, prefix + "DeletionPermission", this.DeletionPermission);
            this.SetParamSimple(map, prefix + "IsAssignManager", this.IsAssignManager);
            this.SetParamSimple(map, prefix + "IsAuthManager", this.IsAuthManager);
            this.SetParamSimple(map, prefix + "IsShareManager", this.IsShareManager);
            this.SetParamSimple(map, prefix + "OperateProcess", this.OperateProcess);
            this.SetParamSimple(map, prefix + "BillingPermission", this.BillingPermission);
            this.SetParamArraySimple(map, prefix + "ExistResources.", this.ExistResources);
            this.SetParamArraySimple(map, prefix + "DetectFailedResources.", this.DetectFailedResources);
        }
    }
}

