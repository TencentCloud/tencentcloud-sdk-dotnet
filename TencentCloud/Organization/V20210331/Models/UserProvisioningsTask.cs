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

    public class UserProvisioningsTask : AbstractModel
    {
        
        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 授权的集团账号目标账号的UIN
        /// </summary>
        [JsonProperty("TargetUin")]
        public long? TargetUin{ get; set; }

        /// <summary>
        /// 同步的集团账号目标账号的类型，ManagerUin管理账号;MemberUin成员账号
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// 任务类型。StartProvisioning：用户同步，DeleteProvisioning：删除用户同步
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 任务状态：InProgress: 进行中，Failed: 失败 3:Success: 成功
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// 用户同步ID。
        /// </summary>
        [JsonProperty("UserProvisioningId")]
        public string UserProvisioningId{ get; set; }

        /// <summary>
        ///  CAM 用户同步的身份 ID。取值： 当PrincipalType取值为Group时，该值为CIC 用户组 ID（g-********）。 当PrincipalType取值为User时，该值为CIC 用户 ID（u-********）。
        /// </summary>
        [JsonProperty("PrincipalId")]
        public string PrincipalId{ get; set; }

        /// <summary>
        /// CAM 用户同步的身份类型。取值： User：表示该 CAM 用户同步的身份是CIC 用户。 Group：表示该 CAM 用户同步的身份是CIC 用户组。
        /// </summary>
        [JsonProperty("PrincipalType")]
        public string PrincipalType{ get; set; }

        /// <summary>
        /// 用户或者用户组名称。
        /// </summary>
        [JsonProperty("PrincipalName")]
        public string PrincipalName{ get; set; }

        /// <summary>
        /// 冲突策略。KeepBoth:两者都保留;TakeOver:替换
        /// </summary>
        [JsonProperty("DuplicationStrategy")]
        public string DuplicationStrategy{ get; set; }

        /// <summary>
        /// 删除策略。Delete:删除;Keep:保留
        /// </summary>
        [JsonProperty("DeletionStrategy")]
        public string DeletionStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "UserProvisioningId", this.UserProvisioningId);
            this.SetParamSimple(map, prefix + "PrincipalId", this.PrincipalId);
            this.SetParamSimple(map, prefix + "PrincipalType", this.PrincipalType);
            this.SetParamSimple(map, prefix + "PrincipalName", this.PrincipalName);
            this.SetParamSimple(map, prefix + "DuplicationStrategy", this.DuplicationStrategy);
            this.SetParamSimple(map, prefix + "DeletionStrategy", this.DeletionStrategy);
        }
    }
}

