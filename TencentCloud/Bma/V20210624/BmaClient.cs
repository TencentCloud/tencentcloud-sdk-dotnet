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

namespace TencentCloud.Bma.V20210624
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bma.V20210624.Models;

   public class BmaClient : AbstractClient{

       private const string endpoint = "bma.tencentcloudapi.com";
       private const string version = "2021-06-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BmaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 版权保护-新建拦截接口
        /// </summary>
        /// <param name="req"><see cref="CreateCRBlockRequest"/></param>
        /// <returns><see cref="CreateCRBlockResponse"/></returns>
        public async Task<CreateCRBlockResponse> CreateCRBlock(CreateCRBlockRequest req)
        {
             JsonResponseModel<CreateCRBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCRBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 版权保护-新建拦截接口
        /// </summary>
        /// <param name="req"><see cref="CreateCRBlockRequest"/></param>
        /// <returns><see cref="CreateCRBlockResponse"/></returns>
        public CreateCRBlockResponse CreateCRBlockSync(CreateCRBlockRequest req)
        {
             JsonResponseModel<CreateCRBlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCRBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 品牌经营管家-版权保护模块企业认证接口
        /// </summary>
        /// <param name="req"><see cref="CreateCRCompanyVerifyRequest"/></param>
        /// <returns><see cref="CreateCRCompanyVerifyResponse"/></returns>
        public async Task<CreateCRCompanyVerifyResponse> CreateCRCompanyVerify(CreateCRCompanyVerifyRequest req)
        {
             JsonResponseModel<CreateCRCompanyVerifyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCRCompanyVerify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRCompanyVerifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 品牌经营管家-版权保护模块企业认证接口
        /// </summary>
        /// <param name="req"><see cref="CreateCRCompanyVerifyRequest"/></param>
        /// <returns><see cref="CreateCRCompanyVerifyResponse"/></returns>
        public CreateCRCompanyVerifyResponse CreateCRCompanyVerifySync(CreateCRCompanyVerifyRequest req)
        {
             JsonResponseModel<CreateCRCompanyVerifyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCRCompanyVerify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRCompanyVerifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 版权保护-新建发函接口
        /// </summary>
        /// <param name="req"><see cref="CreateCRRightRequest"/></param>
        /// <returns><see cref="CreateCRRightResponse"/></returns>
        public async Task<CreateCRRightResponse> CreateCRRight(CreateCRRightRequest req)
        {
             JsonResponseModel<CreateCRRightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCRRight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRRightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 版权保护-新建发函接口
        /// </summary>
        /// <param name="req"><see cref="CreateCRRightRequest"/></param>
        /// <returns><see cref="CreateCRRightResponse"/></returns>
        public CreateCRRightResponse CreateCRRightSync(CreateCRRightRequest req)
        {
             JsonResponseModel<CreateCRRightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCRRight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRRightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询作品基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCRWorkInfoRequest"/></param>
        /// <returns><see cref="DescribeCRWorkInfoResponse"/></returns>
        public async Task<DescribeCRWorkInfoResponse> DescribeCRWorkInfo(DescribeCRWorkInfoRequest req)
        {
             JsonResponseModel<DescribeCRWorkInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCRWorkInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCRWorkInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询作品基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCRWorkInfoRequest"/></param>
        /// <returns><see cref="DescribeCRWorkInfoResponse"/></returns>
        public DescribeCRWorkInfoResponse DescribeCRWorkInfoSync(DescribeCRWorkInfoRequest req)
        {
             JsonResponseModel<DescribeCRWorkInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCRWorkInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCRWorkInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
