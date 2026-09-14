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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelDescribeRolesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。</p><p>此接口下面信息必填。</p><ul><li>渠道应用标识:  Agent.AppId</li><li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li><li>第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId</li></ul>第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// <p>指定每页返回的数据条数，和Offset参数配合使用，单页最大200。</p><p>注: <code>因为历史原因, 此字段为字符串类型</code></p>
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// <p>查询的关键字段:<br>Key:&quot;<strong>RoleType</strong>&quot;,Values:[&quot;<strong>1</strong>&quot;]查询系统角色，<br>Key:&quot;<strong>RoleType</strong>&quot;,Values:[&quot;<strong>2</strong>&quot;]查询自定义角色<br>Key:&quot;<strong>RoleStatus</strong>&quot;,Values:[&quot;<strong>1</strong>&quot;]查询启用角色<br>Key:&quot;<strong>RoleStatus</strong>&quot;,Values:[&quot;<strong>2</strong>&quot;]查询禁用角色<br>Key:&quot;<strong>IsReturnPermissionGroup</strong>&quot;，Values:[&quot;<strong>0</strong>&quot;]表示接口不返回角色对应的权限树字段<br>Key:&quot;<strong>IsReturnPermissionGroup</strong>&quot;，Values:[&quot;<strong>1</strong>&quot;]表示接口返回角色对应的权限树字段</p><p>注: <code>同名字的Key的过滤条件会冲突, 只能填写一个</code></p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>查询结果分页返回，指定从第几页返回数据，和Limit参数配合使用，最大2000条。</p><p>注：<br>1.<code>offset从0开始，即第一页为0。</code><br>2.<code>默认从第一页返回。</code></p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>操作人信息</p>
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

