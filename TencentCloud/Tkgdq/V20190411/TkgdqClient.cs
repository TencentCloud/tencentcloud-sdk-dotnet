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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TkgdqClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 输入实体名称，返回实体相关的信息如实体别名、实体英文名、实体详细信息、相关实体等
        /// </summary>
        /// <param name="req"><see cref="DescribeEntityRequest"/></param>
        /// <returns><see cref="DescribeEntityResponse"/></returns>
        public async Task<DescribeEntityResponse> DescribeEntity(DescribeEntityRequest req)
        {
             JsonResponseModel<DescribeEntityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEntity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEntityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEntity接口的同步版本，输入实体名称，返回实体相关的信息如实体别名、实体英文名、实体详细信息、相关实体等
        /// </summary>
        /// <param name="req">参考<see cref="DescribeEntityRequest"/></param>
        /// <returns>参考<see cref="DescribeEntityResponse"/>实例</returns>
        public DescribeEntityResponse DescribeEntitySync(DescribeEntityRequest req)
        {
             JsonResponseModel<DescribeEntityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEntity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEntityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 输入两个实体，返回两个实体间的关系，例如马化腾与腾讯公司不仅是相关实体，二者还存在隶属关系（马化腾属于腾讯公司）。
        /// </summary>
        /// <param name="req"><see cref="DescribeRelationRequest"/></param>
        /// <returns><see cref="DescribeRelationResponse"/></returns>
        public async Task<DescribeRelationResponse> DescribeRelation(DescribeRelationRequest req)
        {
             JsonResponseModel<DescribeRelationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRelation接口的同步版本，输入两个实体，返回两个实体间的关系，例如马化腾与腾讯公司不仅是相关实体，二者还存在隶属关系（马化腾属于腾讯公司）。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRelationRequest"/></param>
        /// <returns>参考<see cref="DescribeRelationResponse"/>实例</returns>
        public DescribeRelationResponse DescribeRelationSync(DescribeRelationRequest req)
        {
             JsonResponseModel<DescribeRelationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 三元组查询，主要分为两类，SP查询和PO查询。SP查询表示已知主语和谓语查询宾语，PO查询表示已知宾语和谓语查询主语。每一个SP或PO查询都是一个可独立执行的查询，TQL支持SP查询的嵌套查询，即主语可以是一个嵌套的子查询。其他复杂的三元组查询方法，请参考官网API文档示例。
        /// </summary>
        /// <param name="req"><see cref="DescribeTripleRequest"/></param>
        /// <returns><see cref="DescribeTripleResponse"/></returns>
        public async Task<DescribeTripleResponse> DescribeTriple(DescribeTripleRequest req)
        {
             JsonResponseModel<DescribeTripleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTriple");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTripleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTriple接口的同步版本，三元组查询，主要分为两类，SP查询和PO查询。SP查询表示已知主语和谓语查询宾语，PO查询表示已知宾语和谓语查询主语。每一个SP或PO查询都是一个可独立执行的查询，TQL支持SP查询的嵌套查询，即主语可以是一个嵌套的子查询。其他复杂的三元组查询方法，请参考官网API文档示例。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTripleRequest"/></param>
        /// <returns>参考<see cref="DescribeTripleResponse"/>实例</returns>
        public DescribeTripleResponse DescribeTripleSync(DescribeTripleRequest req)
        {
             JsonResponseModel<DescribeTripleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTriple");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTripleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
