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

namespace TencentCloud.Partners.V20180321
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Partners.V20180321.Models;

   public class PartnersClient : AbstractClient{

       private const string endpoint = "partners.tencentcloudapi.com";
       private const string version = "2018-03-21";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public PartnersClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public PartnersClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 代理商可以审核其名下申请中代客
        /// </summary>
        /// <param name="req">参考<see cref="AuditApplyClientRequest"/></param>
        /// <returns>参考<see cref="AuditApplyClientResponse"/>实例</returns>
        public async Task<AuditApplyClientResponse> AuditApplyClient(AuditApplyClientRequest req)
        {
             JsonResponseModel<AuditApplyClientResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AuditApplyClient");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuditApplyClientResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 代理商可查询自己及名下代客所有业务明细
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAgentBillsRequest"/></param>
        /// <returns>参考<see cref="DescribeAgentBillsResponse"/>实例</returns>
        public async Task<DescribeAgentBillsResponse> DescribeAgentBills(DescribeAgentBillsRequest req)
        {
             JsonResponseModel<DescribeAgentBillsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentBills");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentBillsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 代理商可查询自己名下待审核客户列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAgentClientsRequest"/></param>
        /// <returns>参考<see cref="DescribeAgentClientsResponse"/>实例</returns>
        public async Task<DescribeAgentClientsResponse> DescribeAgentClients(DescribeAgentClientsRequest req)
        {
             JsonResponseModel<DescribeAgentClientsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 代理商可查询自己名下全部返佣信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRebateInfosRequest"/></param>
        /// <returns>参考<see cref="DescribeRebateInfosResponse"/>实例</returns>
        public async Task<DescribeRebateInfosResponse> DescribeRebateInfos(DescribeRebateInfosRequest req)
        {
             JsonResponseModel<DescribeRebateInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRebateInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRebateInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 代理商可以对名下客户添加备注、修改备注
        /// </summary>
        /// <param name="req">参考<see cref="ModifyClientRemarkRequest"/></param>
        /// <returns>参考<see cref="ModifyClientRemarkResponse"/>实例</returns>
        public async Task<ModifyClientRemarkResponse> ModifyClientRemark(ModifyClientRemarkRequest req)
        {
             JsonResponseModel<ModifyClientRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClientRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClientRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
