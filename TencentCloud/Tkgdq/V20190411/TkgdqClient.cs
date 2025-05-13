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

namespace TencentCloud.Tkgdq.V20190411
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tkgdq.V20190411.Models;

   public class TkgdqClient : AbstractClient{

       private const string endpoint = "tkgdq.tencentcloudapi.com";
       private const string version = "2019-04-11";
       private const string sdkVersion = "SDK_NET_3.0.1238";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TkgdqClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TkgdqClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 输入实体名称，返回实体相关的信息如实体别名、实体英文名、实体详细信息、相关实体等
        /// </summary>
        /// <param name="req"><see cref="DescribeEntityRequest"/></param>
        /// <returns><see cref="DescribeEntityResponse"/></returns>
        public Task<DescribeEntityResponse> DescribeEntity(DescribeEntityRequest req)
        {
            return InternalRequestAsync<DescribeEntityResponse>(req, "DescribeEntity");
        }

        /// <summary>
        /// 输入实体名称，返回实体相关的信息如实体别名、实体英文名、实体详细信息、相关实体等
        /// </summary>
        /// <param name="req"><see cref="DescribeEntityRequest"/></param>
        /// <returns><see cref="DescribeEntityResponse"/></returns>
        public DescribeEntityResponse DescribeEntitySync(DescribeEntityRequest req)
        {
            return InternalRequestAsync<DescribeEntityResponse>(req, "DescribeEntity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 输入两个实体，返回两个实体间的关系，例如马化腾与腾讯公司不仅是相关实体，二者还存在隶属关系（马化腾属于腾讯公司）。
        /// </summary>
        /// <param name="req"><see cref="DescribeRelationRequest"/></param>
        /// <returns><see cref="DescribeRelationResponse"/></returns>
        public Task<DescribeRelationResponse> DescribeRelation(DescribeRelationRequest req)
        {
            return InternalRequestAsync<DescribeRelationResponse>(req, "DescribeRelation");
        }

        /// <summary>
        /// 输入两个实体，返回两个实体间的关系，例如马化腾与腾讯公司不仅是相关实体，二者还存在隶属关系（马化腾属于腾讯公司）。
        /// </summary>
        /// <param name="req"><see cref="DescribeRelationRequest"/></param>
        /// <returns><see cref="DescribeRelationResponse"/></returns>
        public DescribeRelationResponse DescribeRelationSync(DescribeRelationRequest req)
        {
            return InternalRequestAsync<DescribeRelationResponse>(req, "DescribeRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 三元组查询，主要分为两类，SP查询和PO查询。SP查询表示已知主语和谓语查询宾语，PO查询表示已知宾语和谓语查询主语。每一个SP或PO查询都是一个可独立执行的查询，TQL支持SP查询的嵌套查询，即主语可以是一个嵌套的子查询。其他复杂的三元组查询方法，请参考官网API文档示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeTripleRequest"/></param>
        /// <returns><see cref="DescribeTripleResponse"/></returns>
        public Task<DescribeTripleResponse> DescribeTriple(DescribeTripleRequest req)
        {
            return InternalRequestAsync<DescribeTripleResponse>(req, "DescribeTriple");
        }

        /// <summary>
        /// 三元组查询，主要分为两类，SP查询和PO查询。SP查询表示已知主语和谓语查询宾语，PO查询表示已知宾语和谓语查询主语。每一个SP或PO查询都是一个可独立执行的查询，TQL支持SP查询的嵌套查询，即主语可以是一个嵌套的子查询。其他复杂的三元组查询方法，请参考官网API文档示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeTripleRequest"/></param>
        /// <returns><see cref="DescribeTripleResponse"/></returns>
        public DescribeTripleResponse DescribeTripleSync(DescribeTripleRequest req)
        {
            return InternalRequestAsync<DescribeTripleResponse>(req, "DescribeTriple")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
