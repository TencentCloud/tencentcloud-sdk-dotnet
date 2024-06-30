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

    public class DescribeOrganizationSealsRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 指定分页每页返回的数据条数，如果不传默认为 20，单页最大支持 200。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 指定分页返回第几页的数据，如果不传默认返回第一页，页码从 0 开始，即首页为 0，最大 20000。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 查询授权用户信息类型，取值如下：
        /// 
        /// <ul> <li><b>0</b>：（默认）不返回授权用户信息</li> <li><b>1</b>：返回授权用户的信息</li> </ul>
        /// </summary>
        [JsonProperty("InfoType")]
        public long? InfoType{ get; set; }

        /// <summary>
        /// 印章id，是否查询特定的印章（没有输入返回所有）
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 印章种类列表（均为组织机构印章）。 若无特定需求，将展示所有类型的印章。 
        /// 
        /// 目前支持以下几种：
        /// 
        /// <ul> <li><strong>OFFICIAL</strong>：企业公章；</li> <li><strong>CONTRACT</strong>：合同专用章；</li> <li><strong>ORGANIZATION_SEAL</strong>：企业印章（通过图片上传创建）；</li> <li><strong>LEGAL_PERSON_SEAL</strong>：法定代表人章。</li> </ul>
        /// </summary>
        [JsonProperty("SealTypes")]
        public string[] SealTypes{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 需查询的印章状态列表。
        /// <ul>
        /// <li>空：（默认）仅查询启用状态的印章；</li>
        /// <li><strong>ALL</strong>：查询所有状态的印章；</li>
        /// <li><strong>CHECKING</strong>：查询待审核的印章；</li>
        /// <li><strong>SUCCESS</strong>：查询启用状态的印章；</li>
        /// <li><strong>FAIL</strong>：查询印章审核拒绝的印章；</li>
        /// <li><strong>DISABLE</strong>：查询已停用的印章；</li>
        /// <li><strong>STOPPED</strong>：查询已终止的印章；</li>
        /// <li><strong>VOID</strong>：查询已作废的印章；</li>
        /// <li><strong>INVALID</strong>：查询已失效的印章。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("SealStatuses")]
        public string[] SealStatuses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "InfoType", this.InfoType);
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamArraySimple(map, prefix + "SealTypes.", this.SealTypes);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "SealStatuses.", this.SealStatuses);
        }
    }
}

