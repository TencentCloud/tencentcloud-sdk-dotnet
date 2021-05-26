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

namespace TencentCloud.Eis.V20200715
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Eis.V20200715.Models;

   public class EisClient : AbstractClient{

       private const string endpoint = "eis.tencentcloudapi.com";
       private const string version = "2020-07-15";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 获取连接器配置参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEisConnectorConfigRequest"/></param>
        /// <returns><see cref="DescribeEisConnectorConfigResponse"/></returns>
        public async Task<DescribeEisConnectorConfigResponse> DescribeEisConnectorConfig(DescribeEisConnectorConfigRequest req)
        {
             JsonResponseModel<DescribeEisConnectorConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEisConnectorConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEisConnectorConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取连接器配置参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEisConnectorConfigRequest"/></param>
        /// <returns><see cref="DescribeEisConnectorConfigResponse"/></returns>
        public DescribeEisConnectorConfigResponse DescribeEisConnectorConfigSync(DescribeEisConnectorConfigRequest req)
        {
             JsonResponseModel<DescribeEisConnectorConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEisConnectorConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEisConnectorConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取连接器操作列表
        /// </summary>
        /// <param name="req"><see cref="ListEisConnectorOperationsRequest"/></param>
        /// <returns><see cref="ListEisConnectorOperationsResponse"/></returns>
        public async Task<ListEisConnectorOperationsResponse> ListEisConnectorOperations(ListEisConnectorOperationsRequest req)
        {
             JsonResponseModel<ListEisConnectorOperationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEisConnectorOperations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEisConnectorOperationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取连接器操作列表
        /// </summary>
        /// <param name="req"><see cref="ListEisConnectorOperationsRequest"/></param>
        /// <returns><see cref="ListEisConnectorOperationsResponse"/></returns>
        public ListEisConnectorOperationsResponse ListEisConnectorOperationsSync(ListEisConnectorOperationsRequest req)
        {
             JsonResponseModel<ListEisConnectorOperationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEisConnectorOperations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEisConnectorOperationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 连接器列表
        /// </summary>
        /// <param name="req"><see cref="ListEisConnectorsRequest"/></param>
        /// <returns><see cref="ListEisConnectorsResponse"/></returns>
        public async Task<ListEisConnectorsResponse> ListEisConnectors(ListEisConnectorsRequest req)
        {
             JsonResponseModel<ListEisConnectorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEisConnectors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEisConnectorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 连接器列表
        /// </summary>
        /// <param name="req"><see cref="ListEisConnectorsRequest"/></param>
        /// <returns><see cref="ListEisConnectorsResponse"/></returns>
        public ListEisConnectorsResponse ListEisConnectorsSync(ListEisConnectorsRequest req)
        {
             JsonResponseModel<ListEisConnectorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEisConnectors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEisConnectorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
