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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyIntegrationDepartmentRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得组织架构管理权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 电子签部门ID，通过<a href="https://qian.tencent.com/developers/companyApis/organizations/DescribeIntegrationDepartments" target="_blank">DescribeIntegrationDepartments</a>接口获得。
        /// </summary>
        [JsonProperty("DeptId")]
        public string DeptId{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 电子签父部门ID，通过<a href="https://qian.tencent.com/developers/companyApis/organizations/DescribeIntegrationDepartments" target="_blank">DescribeIntegrationDepartments</a>接口获得。
        /// </summary>
        [JsonProperty("ParentDeptId")]
        public string ParentDeptId{ get; set; }

        /// <summary>
        /// 部门名称，最大长度为50个字符。
        /// </summary>
        [JsonProperty("DeptName")]
        public string DeptName{ get; set; }

        /// <summary>
        /// 客户系统部门ID，最大长度为64个字符。
        /// </summary>
        [JsonProperty("DeptOpenId")]
        public string DeptOpenId{ get; set; }

        /// <summary>
        /// 排序号，支持设置的数值范围为1~30000。同一父部门下，排序号越大，部门顺序越靠前。
        /// </summary>
        [JsonProperty("OrderNo")]
        public ulong? OrderNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "DeptId", this.DeptId);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ParentDeptId", this.ParentDeptId);
            this.SetParamSimple(map, prefix + "DeptName", this.DeptName);
            this.SetParamSimple(map, prefix + "DeptOpenId", this.DeptOpenId);
            this.SetParamSimple(map, prefix + "OrderNo", this.OrderNo);
        }
    }
}

