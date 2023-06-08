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

namespace TencentCloud.Csip.V20221121
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Csip.V20221121.Models;

   public class CsipClient : AbstractClient{

       private const string endpoint = "csip.tencentcloudapi.com";
       private const string version = "2022-11-21";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CsipClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CsipClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// csip角色授权绑定接口
        /// </summary>
        /// <param name="req"><see cref="AddNewBindRoleUserRequest"/></param>
        /// <returns><see cref="AddNewBindRoleUserResponse"/></returns>
        public async Task<AddNewBindRoleUserResponse> AddNewBindRoleUser(AddNewBindRoleUserRequest req)
        {
             JsonResponseModel<AddNewBindRoleUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddNewBindRoleUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNewBindRoleUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// csip角色授权绑定接口
        /// </summary>
        /// <param name="req"><see cref="AddNewBindRoleUserRequest"/></param>
        /// <returns><see cref="AddNewBindRoleUserResponse"/></returns>
        public AddNewBindRoleUserResponse AddNewBindRoleUserSync(AddNewBindRoleUserRequest req)
        {
             JsonResponseModel<AddNewBindRoleUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddNewBindRoleUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNewBindRoleUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建域名、ip相关信息
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAndIpRequest"/></param>
        /// <returns><see cref="CreateDomainAndIpResponse"/></returns>
        public async Task<CreateDomainAndIpResponse> CreateDomainAndIp(CreateDomainAndIpRequest req)
        {
             JsonResponseModel<CreateDomainAndIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomainAndIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainAndIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建域名、ip相关信息
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAndIpRequest"/></param>
        /// <returns><see cref="CreateDomainAndIpResponse"/></returns>
        public CreateDomainAndIpResponse CreateDomainAndIpSync(CreateDomainAndIpRequest req)
        {
             JsonResponseModel<CreateDomainAndIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomainAndIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainAndIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// cvm详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetInfoResponse"/></returns>
        public async Task<DescribeCVMAssetInfoResponse> DescribeCVMAssetInfo(DescribeCVMAssetInfoRequest req)
        {
             JsonResponseModel<DescribeCVMAssetInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCVMAssetInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCVMAssetInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// cvm详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetInfoResponse"/></returns>
        public DescribeCVMAssetInfoResponse DescribeCVMAssetInfoSync(DescribeCVMAssetInfoRequest req)
        {
             JsonResponseModel<DescribeCVMAssetInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCVMAssetInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCVMAssetInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// cvm列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetsRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetsResponse"/></returns>
        public async Task<DescribeCVMAssetsResponse> DescribeCVMAssets(DescribeCVMAssetsRequest req)
        {
             JsonResponseModel<DescribeCVMAssetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCVMAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCVMAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// cvm列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetsRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetsResponse"/></returns>
        public DescribeCVMAssetsResponse DescribeCVMAssetsSync(DescribeCVMAssetsRequest req)
        {
             JsonResponseModel<DescribeCVMAssetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCVMAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCVMAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// db资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeDbAssetInfoResponse"/></returns>
        public async Task<DescribeDbAssetInfoResponse> DescribeDbAssetInfo(DescribeDbAssetInfoRequest req)
        {
             JsonResponseModel<DescribeDbAssetInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDbAssetInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbAssetInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// db资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeDbAssetInfoResponse"/></returns>
        public DescribeDbAssetInfoResponse DescribeDbAssetInfoSync(DescribeDbAssetInfoRequest req)
        {
             JsonResponseModel<DescribeDbAssetInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDbAssetInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbAssetInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetsRequest"/></param>
        /// <returns><see cref="DescribeDbAssetsResponse"/></returns>
        public async Task<DescribeDbAssetsResponse> DescribeDbAssets(DescribeDbAssetsRequest req)
        {
             JsonResponseModel<DescribeDbAssetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDbAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetsRequest"/></param>
        /// <returns><see cref="DescribeDbAssetsResponse"/></returns>
        public DescribeDbAssetsResponse DescribeDbAssetsSync(DescribeDbAssetsRequest req)
        {
             JsonResponseModel<DescribeDbAssetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDbAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取扫描报告列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanReportListRequest"/></param>
        /// <returns><see cref="DescribeScanReportListResponse"/></returns>
        public async Task<DescribeScanReportListResponse> DescribeScanReportList(DescribeScanReportListRequest req)
        {
             JsonResponseModel<DescribeScanReportListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanReportList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanReportListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取扫描报告列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanReportListRequest"/></param>
        /// <returns><see cref="DescribeScanReportListResponse"/></returns>
        public DescribeScanReportListResponse DescribeScanReportListSync(DescribeScanReportListRequest req)
        {
             JsonResponseModel<DescribeScanReportListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanReportList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanReportListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAssetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAssetsResponse"/></returns>
        public async Task<DescribeSubnetAssetsResponse> DescribeSubnetAssets(DescribeSubnetAssetsRequest req)
        {
             JsonResponseModel<DescribeSubnetAssetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubnetAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAssetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAssetsResponse"/></returns>
        public DescribeSubnetAssetsResponse DescribeSubnetAssetsSync(DescribeSubnetAssetsRequest req)
        {
             JsonResponseModel<DescribeSubnetAssetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubnetAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取vpc列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAssetsRequest"/></param>
        /// <returns><see cref="DescribeVpcAssetsResponse"/></returns>
        public async Task<DescribeVpcAssetsResponse> DescribeVpcAssets(DescribeVpcAssetsRequest req)
        {
             JsonResponseModel<DescribeVpcAssetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取vpc列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAssetsRequest"/></param>
        /// <returns><see cref="DescribeVpcAssetsResponse"/></returns>
        public DescribeVpcAssetsResponse DescribeVpcAssetsSync(DescribeVpcAssetsRequest req)
        {
             JsonResponseModel<DescribeVpcAssetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
