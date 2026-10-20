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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PermissionApplyOrder : AbstractModel
    {
        
        /// <summary>
        /// <p>申请单 ID</p>
        /// </summary>
        [JsonProperty("ApplyId")]
        public string ApplyId{ get; set; }

        /// <summary>
        /// <p>申请人用户 ID</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>申请人用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>目标成员账号 UIN</p>
        /// </summary>
        [JsonProperty("TargetUin")]
        public long? TargetUin{ get; set; }

        /// <summary>
        /// <p>目标成员账号名称</p>
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// <p>申请的权限配置</p>
        /// </summary>
        [JsonProperty("RoleConfigurations")]
        public ApplyRoleConfiguration[] RoleConfigurations{ get; set; }

        /// <summary>
        /// <p>申请单状态</p><p>枚举值：</p><ul><li>1： 待审核</li><li>2： 已通过 - 同步中</li><li>3： 已通过 - 同步成功</li><li>4： 已通过 - 同步失败</li><li>5： 已拒绝</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>参数格式：YYYY-M-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>审批意见</p>
        /// </summary>
        [JsonProperty("AuditOpinion")]
        public string AuditOpinion{ get; set; }

        /// <summary>
        /// <p>审批时间</p><p>参数格式：YYYY-M-DD hh:mm:ss</p><p>未审批为空</p>
        /// </summary>
        [JsonProperty("AuditTime")]
        public string AuditTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplyId", this.ApplyId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamArrayObj(map, prefix + "RoleConfigurations.", this.RoleConfigurations);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AuditOpinion", this.AuditOpinion);
            this.SetParamSimple(map, prefix + "AuditTime", this.AuditTime);
        }
    }
}

