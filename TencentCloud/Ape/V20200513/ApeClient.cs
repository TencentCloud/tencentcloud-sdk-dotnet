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

namespace TencentCloud.Ape.V20200513
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ape.V20200513.Models;

   public class ApeClient : AbstractClient{

       private const string endpoint = "ape.tencentcloudapi.com";
       private const string version = "2020-05-13";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ApeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 批量获取授权书下载地址
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeOrderCertificateRequest"/></param>
        /// <returns><see cref="BatchDescribeOrderCertificateResponse"/></returns>
        public async Task<BatchDescribeOrderCertificateResponse> BatchDescribeOrderCertificate(BatchDescribeOrderCertificateRequest req)
        {
             JsonResponseModel<BatchDescribeOrderCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDescribeOrderCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDescribeOrderCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取授权书下载地址
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeOrderCertificateRequest"/></param>
        /// <returns><see cref="BatchDescribeOrderCertificateResponse"/></returns>
        public BatchDescribeOrderCertificateResponse BatchDescribeOrderCertificateSync(BatchDescribeOrderCertificateRequest req)
        {
             JsonResponseModel<BatchDescribeOrderCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDescribeOrderCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDescribeOrderCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取图片下载地址
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeOrderImageRequest"/></param>
        /// <returns><see cref="BatchDescribeOrderImageResponse"/></returns>
        public async Task<BatchDescribeOrderImageResponse> BatchDescribeOrderImage(BatchDescribeOrderImageRequest req)
        {
             JsonResponseModel<BatchDescribeOrderImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDescribeOrderImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDescribeOrderImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量获取图片下载地址
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeOrderImageRequest"/></param>
        /// <returns><see cref="BatchDescribeOrderImageResponse"/></returns>
        public BatchDescribeOrderImageResponse BatchDescribeOrderImageSync(BatchDescribeOrderImageRequest req)
        {
             JsonResponseModel<BatchDescribeOrderImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDescribeOrderImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDescribeOrderImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核销图片，获取原图URL地址
        /// </summary>
        /// <param name="req"><see cref="CreateOrderAndDownloadsRequest"/></param>
        /// <returns><see cref="CreateOrderAndDownloadsResponse"/></returns>
        public async Task<CreateOrderAndDownloadsResponse> CreateOrderAndDownloads(CreateOrderAndDownloadsRequest req)
        {
             JsonResponseModel<CreateOrderAndDownloadsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrderAndDownloads");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrderAndDownloadsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 核销图片，获取原图URL地址
        /// </summary>
        /// <param name="req"><see cref="CreateOrderAndDownloadsRequest"/></param>
        /// <returns><see cref="CreateOrderAndDownloadsResponse"/></returns>
        public CreateOrderAndDownloadsResponse CreateOrderAndDownloadsSync(CreateOrderAndDownloadsRequest req)
        {
             JsonResponseModel<CreateOrderAndDownloadsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrderAndDownloads");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrderAndDownloadsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买一张图片并且支付
        /// </summary>
        /// <param name="req"><see cref="CreateOrderAndPayRequest"/></param>
        /// <returns><see cref="CreateOrderAndPayResponse"/></returns>
        public async Task<CreateOrderAndPayResponse> CreateOrderAndPay(CreateOrderAndPayRequest req)
        {
             JsonResponseModel<CreateOrderAndPayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrderAndPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrderAndPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买一张图片并且支付
        /// </summary>
        /// <param name="req"><see cref="CreateOrderAndPayRequest"/></param>
        /// <returns><see cref="CreateOrderAndPayResponse"/></returns>
        public CreateOrderAndPayResponse CreateOrderAndPaySync(CreateOrderAndPayRequest req)
        {
             JsonResponseModel<CreateOrderAndPayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrderAndPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrderAndPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询授权人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthUsersRequest"/></param>
        /// <returns><see cref="DescribeAuthUsersResponse"/></returns>
        public async Task<DescribeAuthUsersResponse> DescribeAuthUsers(DescribeAuthUsersRequest req)
        {
             JsonResponseModel<DescribeAuthUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAuthUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuthUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询授权人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthUsersRequest"/></param>
        /// <returns><see cref="DescribeAuthUsersResponse"/></returns>
        public DescribeAuthUsersResponse DescribeAuthUsersSync(DescribeAuthUsersRequest req)
        {
             JsonResponseModel<DescribeAuthUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAuthUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuthUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户图片下载记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadInfosRequest"/></param>
        /// <returns><see cref="DescribeDownloadInfosResponse"/></returns>
        public async Task<DescribeDownloadInfosResponse> DescribeDownloadInfos(DescribeDownloadInfosRequest req)
        {
             JsonResponseModel<DescribeDownloadInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDownloadInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDownloadInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户图片下载记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadInfosRequest"/></param>
        /// <returns><see cref="DescribeDownloadInfosResponse"/></returns>
        public DescribeDownloadInfosResponse DescribeDownloadInfosSync(DescribeDownloadInfosRequest req)
        {
             JsonResponseModel<DescribeDownloadInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDownloadInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDownloadInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据ID查询一张图片的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public async Task<DescribeImageResponse> DescribeImage(DescribeImageRequest req)
        {
             JsonResponseModel<DescribeImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据ID查询一张图片的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public DescribeImageResponse DescribeImageSync(DescribeImageRequest req)
        {
             JsonResponseModel<DescribeImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据关键字搜索图片列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public async Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据关键字搜索图片列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
