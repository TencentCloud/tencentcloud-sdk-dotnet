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

    public class DescribeFlowTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方员工/经办人信息
        /// UserId 必填，在企业控制台组织架构中可以查到员工的UserId
        /// 注：请保证对应
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 代理相关应用信息
        /// 如集团主企业代子企业操作的场景中ProxyOrganizationId必填
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 查询内容类型
        /// 0-模板列表及详情（默认）
        /// 1-仅模板列表
        /// </summary>
        [JsonProperty("ContentType")]
        public long? ContentType{ get; set; }

        /// <summary>
        /// 搜索条件，本字段用于指定模板Id进行查询。
        /// Key：template-id
        /// Values：需要查询的模板Id列表
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 查询结果分页返回，此处指定第几页，如果不传默从第一页返回。页码从0开始，即首页为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 指定每页多少条数据，如果不传默认为20，单页最大200。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 用于查询指定应用号下单模板列表。
        /// ApplicationId不为空，查询指定应用下的模板列表
        /// ApplicationId为空，查询所有应用下的模板列表
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 默认为false，查询SaaS模板库列表；
        /// 为true，查询第三方应用集成平台企业模板库管理列表
        /// </summary>
        [JsonProperty("IsChannel")]
        [System.Obsolete]
        public bool? IsChannel{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Organization")]
        [System.Obsolete]
        public OrganizationInfo Organization{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("GenerateSource")]
        [System.Obsolete]
        public ulong? GenerateSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "IsChannel", this.IsChannel);
            this.SetParamObj(map, prefix + "Organization.", this.Organization);
            this.SetParamSimple(map, prefix + "GenerateSource", this.GenerateSource);
        }
    }
}

