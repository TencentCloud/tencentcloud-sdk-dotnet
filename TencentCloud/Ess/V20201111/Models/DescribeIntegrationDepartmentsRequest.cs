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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIntegrationDepartmentsRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作人信息，UserId必填且需拥有组织架构管理权限
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 查询类型 0-查询单个部门节点 1-单个部门节点及一级子节点部门列表
        /// </summary>
        [JsonProperty("QueryType")]
        public ulong? QueryType{ get; set; }

        /// <summary>
        /// 部门ID,与DeptOpenId二选一,优先DeptId,都为空时获取根节点数据
        /// </summary>
        [JsonProperty("DeptId")]
        public string DeptId{ get; set; }

        /// <summary>
        /// 客户系统部门ID,与DeptId二选一,优先DeptId,都为空时获取根节点数据
        /// </summary>
        [JsonProperty("DeptOpenId")]
        public string DeptOpenId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
            this.SetParamSimple(map, prefix + "DeptId", this.DeptId);
            this.SetParamSimple(map, prefix + "DeptOpenId", this.DeptOpenId);
        }
    }
}

