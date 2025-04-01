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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRoleListRequest : AbstractModel
    {
        
        /// <summary>
        /// 返回所有角色。
        /// </summary>
        [JsonProperty("ShowAllRoles")]
        public bool? ShowAllRoles{ get; set; }

        /// <summary>
        /// 需要返回的角色类型(system,tenant,project)
        /// </summary>
        [JsonProperty("IncludeRoleTypes")]
        public string[] IncludeRoleTypes{ get; set; }

        /// <summary>
        /// 返回角色绑定人员统计，仅私有化版本支持
        /// </summary>
        [JsonProperty("DescribeMemberCount")]
        public bool? DescribeMemberCount{ get; set; }

        /// <summary>
        /// 返回操作者信息，私有化多租户版本
        /// </summary>
        [JsonProperty("DescribeOperator")]
        public bool? DescribeOperator{ get; set; }

        /// <summary>
        /// 系统角色
        /// </summary>
        [JsonProperty("DescribeSystemRoleOnly")]
        public bool? DescribeSystemRoleOnly{ get; set; }

        /// <summary>
        /// 自定义角色
        /// </summary>
        [JsonProperty("DescribeCustomRoleOnly")]
        public bool? DescribeCustomRoleOnly{ get; set; }

        /// <summary>
        /// 查看权限
        /// </summary>
        [JsonProperty("DescribePrivileges")]
        public bool? DescribePrivileges{ get; set; }

        /// <summary>
        /// 筛选角色id
        /// </summary>
        [JsonProperty("RoleIds")]
        public string[] RoleIds{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 查询字段
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderFields[] OrderFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShowAllRoles", this.ShowAllRoles);
            this.SetParamArraySimple(map, prefix + "IncludeRoleTypes.", this.IncludeRoleTypes);
            this.SetParamSimple(map, prefix + "DescribeMemberCount", this.DescribeMemberCount);
            this.SetParamSimple(map, prefix + "DescribeOperator", this.DescribeOperator);
            this.SetParamSimple(map, prefix + "DescribeSystemRoleOnly", this.DescribeSystemRoleOnly);
            this.SetParamSimple(map, prefix + "DescribeCustomRoleOnly", this.DescribeCustomRoleOnly);
            this.SetParamSimple(map, prefix + "DescribePrivileges", this.DescribePrivileges);
            this.SetParamArraySimple(map, prefix + "RoleIds.", this.RoleIds);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
        }
    }
}

