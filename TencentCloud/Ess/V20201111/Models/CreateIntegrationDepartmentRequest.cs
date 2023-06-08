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

    public class CreateIntegrationDepartmentRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作人信息，UserId必填且需拥有组织架构管理权限
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 部门名称，不超过50个字符
        /// </summary>
        [JsonProperty("DeptName")]
        public string DeptName{ get; set; }

        /// <summary>
        /// 电子签父部门ID，与ParentDeptOpenId二选一,优先ParentDeptId,都为空时自动填充至根节点下
        /// </summary>
        [JsonProperty("ParentDeptId")]
        public string ParentDeptId{ get; set; }

        /// <summary>
        /// 第三方平台中父部门ID,与ParentDeptId二选一,优先ParentDeptId,都为空时自动填充至根节点下
        /// </summary>
        [JsonProperty("ParentDeptOpenId")]
        public string ParentDeptOpenId{ get; set; }

        /// <summary>
        /// 客户系统部门ID，不超过64个字符
        /// </summary>
        [JsonProperty("DeptOpenId")]
        public string DeptOpenId{ get; set; }

        /// <summary>
        /// 排序号,1~30000范围内
        /// </summary>
        [JsonProperty("OrderNo")]
        public ulong? OrderNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "DeptName", this.DeptName);
            this.SetParamSimple(map, prefix + "ParentDeptId", this.ParentDeptId);
            this.SetParamSimple(map, prefix + "ParentDeptOpenId", this.ParentDeptOpenId);
            this.SetParamSimple(map, prefix + "DeptOpenId", this.DeptOpenId);
            this.SetParamSimple(map, prefix + "OrderNo", this.OrderNo);
        }
    }
}

