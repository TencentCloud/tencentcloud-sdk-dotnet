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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Ticket : AbstractModel
    {
        
        /// <summary>
        /// <p>数据库主键</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>工单ID,id-s3ed4r5e</p>
        /// </summary>
        [JsonProperty("TicketId")]
        public string TicketId{ get; set; }

        /// <summary>
        /// <p>工单类型，0-运维访问工单，1-权限工单, 2-数据库变更工单,3-自动执行命令/脚本工单</p>
        /// </summary>
        [JsonProperty("TicketType")]
        public ulong? TicketType{ get; set; }

        /// <summary>
        /// <p>acl权限</p>
        /// </summary>
        [JsonProperty("Acl")]
        public Acl Acl{ get; set; }

        /// <summary>
        /// <p>运维开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>运维结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>工单状态，0待提交(草稿)，1待审批，2批准，3已执行，4驳回,5删除，6过期</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>申请时间</p>
        /// </summary>
        [JsonProperty("ApplyTime")]
        public string ApplyTime{ get; set; }

        /// <summary>
        /// <p>申请人用户Id</p>
        /// </summary>
        [JsonProperty("ApplyUser")]
        public ulong? ApplyUser{ get; set; }

        /// <summary>
        /// <p>审批人uin</p>
        /// </summary>
        [JsonProperty("ApproveUser")]
        public string ApproveUser{ get; set; }

        /// <summary>
        /// <p>工单审批备注</p>
        /// </summary>
        [JsonProperty("ApproveDesc")]
        public string ApproveDesc{ get; set; }

        /// <summary>
        /// <p>acl权限Id</p>
        /// </summary>
        [JsonProperty("AclId")]
        public ulong? AclId{ get; set; }

        /// <summary>
        /// <p>待审批状态下，可以审批的人</p>
        /// </summary>
        [JsonProperty("ApproveUserSet")]
        public string[] ApproveUserSet{ get; set; }

        /// <summary>
        /// <p>审批人信息</p>
        /// </summary>
        [JsonProperty("ApproveUserInfoSet")]
        public DepartmentManagerUser[] ApproveUserInfoSet{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>申请权限</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>审批时间</p>
        /// </summary>
        [JsonProperty("ApproveTime")]
        public string ApproveTime{ get; set; }

        /// <summary>
        /// <p>部门ID</p>
        /// </summary>
        [JsonProperty("DepartmentId")]
        public string DepartmentId{ get; set; }

        /// <summary>
        /// <p>部门名称</p>
        /// </summary>
        [JsonProperty("DepartmentName")]
        public string DepartmentName{ get; set; }

        /// <summary>
        /// <p>部门Sequence</p>
        /// </summary>
        [JsonProperty("DepartmentSequence")]
        public ulong? DepartmentSequence{ get; set; }

        /// <summary>
        /// <p>申请人用户名</p>
        /// </summary>
        [JsonProperty("ApplyUserName")]
        public string ApplyUserName{ get; set; }

        /// <summary>
        /// <p>申请人真实姓名</p>
        /// </summary>
        [JsonProperty("ApplyRealName")]
        public string ApplyRealName{ get; set; }

        /// <summary>
        /// <p>申请时间戳，微妙</p>
        /// </summary>
        [JsonProperty("ApplyTimeVersion")]
        public long? ApplyTimeVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TicketId", this.TicketId);
            this.SetParamSimple(map, prefix + "TicketType", this.TicketType);
            this.SetParamObj(map, prefix + "Acl.", this.Acl);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "ApplyUser", this.ApplyUser);
            this.SetParamSimple(map, prefix + "ApproveUser", this.ApproveUser);
            this.SetParamSimple(map, prefix + "ApproveDesc", this.ApproveDesc);
            this.SetParamSimple(map, prefix + "AclId", this.AclId);
            this.SetParamArraySimple(map, prefix + "ApproveUserSet.", this.ApproveUserSet);
            this.SetParamArrayObj(map, prefix + "ApproveUserInfoSet.", this.ApproveUserInfoSet);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
            this.SetParamSimple(map, prefix + "DepartmentId", this.DepartmentId);
            this.SetParamSimple(map, prefix + "DepartmentName", this.DepartmentName);
            this.SetParamSimple(map, prefix + "DepartmentSequence", this.DepartmentSequence);
            this.SetParamSimple(map, prefix + "ApplyUserName", this.ApplyUserName);
            this.SetParamSimple(map, prefix + "ApplyRealName", this.ApplyRealName);
            this.SetParamSimple(map, prefix + "ApplyTimeVersion", this.ApplyTimeVersion);
        }
    }
}

