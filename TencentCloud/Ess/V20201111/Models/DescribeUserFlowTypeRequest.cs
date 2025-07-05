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

    public class DescribeUserFlowTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 搜索过滤的条件，本字段允许您通过指定模板 ID 或模板名称来进行查询。
        /// <ul><li><strong>模板 ID</strong>：<strong>Key</strong>设置为 <code>template-id</code> ，<strong>Values</strong>为您想要查询的 <a href="https://qcloudimg.tencent-cloud.cn/raw/5c27b917b2bbe8c341566c78ca6f8782.png" target="_blank">模板 ID </a>列表。</li>  <li><strong>主企业模板 ID</strong>：<strong>Key</strong>设置为 <code>share-template-id</code> ，<strong>Values</strong>为您想要查询的 <a href="https://qcloudimg.tencent-cloud.cn/raw/5c27b917b2bbe8c341566c78ca6f8782.png" target="_blank">主企业模板 ID </a>列表。用来查询主企业分享模板到子企业场景下，子企业的模板信息，在此情境下，参数 <strong>Agent.ProxyOrganizationId</strong>（子企业的组织ID）为必填项。</li> <li><strong>模板名称</strong>：<strong>Key</strong>设置为 <code>template-name</code> ，<strong>Values</strong>为您想要查询的<a href="https://qcloudimg.tencent-cloud.cn/raw/03a924ee0a53d86575f8067d1c97876d.png" target="_blank">模板名称</a>列表。</li><li><strong>模板的用户合同类型</strong>：<strong>Key</strong>设置为 <code>user-flow-type-id</code> ，<strong>Values</strong>为您想要查询的用户模版类型id列表。</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 查询绑定了模版的用户合同类型 <ul> <li>false（默认值），查询用户合同类型</li> <li>true，查询绑定了模版的用户合同类型</li> </ul>	
        /// </summary>
        [JsonProperty("QueryBindTemplate")]
        public bool? QueryBindTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "QueryBindTemplate", this.QueryBindTemplate);
        }
    }
}

