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

    public class DescribeOrganizationGroupOrganizationsRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息,userId必填。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 指定分页每页返回的数据条数，单页最大1000
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 指定分页返回第几页的数据，如果不传默认返回第一页，页码从 0 开始，即首页为 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 查询成员企业的企业名，模糊匹配
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 成员企业加入集团的当前状态
        /// <ul><li> **1**：待授权</li>
        /// <li> **2**：已授权待激活</li>
        /// <li> **3**：拒绝授权</li>
        /// <li> **4**：已解除</li>
        /// <li> **5**：已加入</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 是否导出当前成员企业数据
        /// <ul><li> **false**：不导出（默认值）</li>
        /// <li> **true**：导出</li></ul>
        /// </summary>
        [JsonProperty("Export")]
        public bool? Export{ get; set; }

        /// <summary>
        /// 成员企业机构 ID，32 位字符串，在PC控制台 集团管理可获取
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Export", this.Export);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

