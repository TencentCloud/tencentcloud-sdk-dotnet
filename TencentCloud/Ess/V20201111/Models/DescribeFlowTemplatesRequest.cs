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
        /// 查询内容控制
        /// 
        /// <ul><li>**0**：模板列表及详情（默认）</li>
        /// <li>**1**：仅模板列表</li></ul>
        /// </summary>
        [JsonProperty("ContentType")]
        public long? ContentType{ get; set; }

        /// <summary>
        /// 搜索过滤的条件，本字段允许您通过指定模板 ID 或模板名称来进行查询。
        /// <ul><li><strong>模板 ID</strong>：<strong>Key</strong>设置为 <code>template-id</code> ，<strong>Values</strong>为您想要查询的 <a href="https://qcloudimg.tencent-cloud.cn/raw/5c27b917b2bbe8c341566c78ca6f8782.png" target="_blank">模板 ID </a>列表。</li>  <li><strong>主企业模板 ID</strong>：<strong>Key</strong>设置为 <code>share-template-id</code> ，<strong>Values</strong>为您想要查询的 <a href="https://qcloudimg.tencent-cloud.cn/raw/5c27b917b2bbe8c341566c78ca6f8782.png" target="_blank">主企业模板 ID </a>列表。用来查询主企业分享模板到子企业场景下，子企业的模板信息，在此情境下，参数 <strong>Agent.ProxyOrganizationId</strong>（子企业的组织ID）为必填项。</li> <li><strong>模板名称</strong>：<strong>Key</strong>设置为 <code>template-name</code> ，<strong>Values</strong>为您想要查询的<a href="https://qcloudimg.tencent-cloud.cn/raw/03a924ee0a53d86575f8067d1c97876d.png" target="_blank">模板名称</a>列表。</li><li><strong>模板的用户合同类型</strong>：<strong>Key</strong>设置为 <code>user-flow-type-id</code> ，<strong>Values</strong>为您想要查询的用户模版类型id列表。</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 查询结果分页返回，指定从第几页返回数据，和Limit参数配合使用。
        /// 
        /// 注：`1.offset从0开始，即第一页为0。`
        /// `2.默认从第一页返回。`
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 指定每页返回的数据条数，和Offset参数配合使用。
        /// 
        /// 注：`1.默认值为20，单页做大值为200。`
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 通过指定[第三方应用的应用号（ApplicationId）](https://qcloudimg.tencent-cloud.cn/raw/60efa1e9049732e5246b20a268882b1a.png)，您可以查询<a href="https://qcloudimg.tencent-cloud.cn/raw/18319e5e77f7d47eab493d43d47827d3.png" target="_blank">【应用模板库管理】</a>中某个第三方应用下的模板。
        /// 
        /// <p><strong>注意事项：</strong></p>
        /// <ul><li>当 <strong>ApplicationId</strong> 为空时（默认），系统将查询<a href="https://qcloudimg.tencent-cloud.cn/raw/376943a1d472393dd5388592f2e85ee5.png" target="_blank">平台企业的所有模板</a>（自建应用使用的模板）。</li><li>当 <strong>ApplicationId</strong> 不为空时，系统将从<a href="https://qcloudimg.tencent-cloud.cn/raw/18319e5e77f7d47eab493d43d47827d3.png" target="_blank">【应用模板库管理】</a>中查询该特定应用下的模板（分享给第三方应用子企业的模板）。</li></ul>
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
        /// 是否获取模板预览链接。
        /// 
        /// <ul><li><strong>false</strong>：不获取（默认）</li><li><strong>true</strong>：需要获取</li></ul>
        /// 设置为true之后， 返回参数PreviewUrl，为模板的H5预览链接, 有效期5分钟。可以通过浏览器打开此链接预览模板，或者嵌入到iframe中预览模板。
        /// </summary>
        [JsonProperty("WithPreviewUrl")]
        public bool? WithPreviewUrl{ get; set; }


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
            this.SetParamSimple(map, prefix + "WithPreviewUrl", this.WithPreviewUrl);
        }
    }
}

