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
       private const string sdkVersion = "SDK_NET_3.0.1177";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 批量获取授权书下载地址
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeOrderCertificateRequest"/></param>
        /// <returns><see cref="BatchDescribeOrderCertificateResponse"/></returns>
        public Task<BatchDescribeOrderCertificateResponse> BatchDescribeOrderCertificate(BatchDescribeOrderCertificateRequest req)
        {
            return InternalRequestAsync<BatchDescribeOrderCertificateResponse>(req, "BatchDescribeOrderCertificate");
        }

        /// <summary>
        /// 批量获取授权书下载地址
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeOrderCertificateRequest"/></param>
        /// <returns><see cref="BatchDescribeOrderCertificateResponse"/></returns>
        public BatchDescribeOrderCertificateResponse BatchDescribeOrderCertificateSync(BatchDescribeOrderCertificateRequest req)
        {
            return InternalRequestAsync<BatchDescribeOrderCertificateResponse>(req, "BatchDescribeOrderCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量获取图片下载地址
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeOrderImageRequest"/></param>
        /// <returns><see cref="BatchDescribeOrderImageResponse"/></returns>
        public Task<BatchDescribeOrderImageResponse> BatchDescribeOrderImage(BatchDescribeOrderImageRequest req)
        {
            return InternalRequestAsync<BatchDescribeOrderImageResponse>(req, "BatchDescribeOrderImage");
        }

        /// <summary>
        /// 批量获取图片下载地址
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeOrderImageRequest"/></param>
        /// <returns><see cref="BatchDescribeOrderImageResponse"/></returns>
        public BatchDescribeOrderImageResponse BatchDescribeOrderImageSync(BatchDescribeOrderImageRequest req)
        {
            return InternalRequestAsync<BatchDescribeOrderImageResponse>(req, "BatchDescribeOrderImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 核销图片，获取原图URL地址
        /// </summary>
        /// <param name="req"><see cref="CreateOrderAndDownloadsRequest"/></param>
        /// <returns><see cref="CreateOrderAndDownloadsResponse"/></returns>
        public Task<CreateOrderAndDownloadsResponse> CreateOrderAndDownloads(CreateOrderAndDownloadsRequest req)
        {
            return InternalRequestAsync<CreateOrderAndDownloadsResponse>(req, "CreateOrderAndDownloads");
        }

        /// <summary>
        /// 核销图片，获取原图URL地址
        /// </summary>
        /// <param name="req"><see cref="CreateOrderAndDownloadsRequest"/></param>
        /// <returns><see cref="CreateOrderAndDownloadsResponse"/></returns>
        public CreateOrderAndDownloadsResponse CreateOrderAndDownloadsSync(CreateOrderAndDownloadsRequest req)
        {
            return InternalRequestAsync<CreateOrderAndDownloadsResponse>(req, "CreateOrderAndDownloads")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买一张图片并且支付
        /// </summary>
        /// <param name="req"><see cref="CreateOrderAndPayRequest"/></param>
        /// <returns><see cref="CreateOrderAndPayResponse"/></returns>
        public Task<CreateOrderAndPayResponse> CreateOrderAndPay(CreateOrderAndPayRequest req)
        {
            return InternalRequestAsync<CreateOrderAndPayResponse>(req, "CreateOrderAndPay");
        }

        /// <summary>
        /// 购买一张图片并且支付
        /// </summary>
        /// <param name="req"><see cref="CreateOrderAndPayRequest"/></param>
        /// <returns><see cref="CreateOrderAndPayResponse"/></returns>
        public CreateOrderAndPayResponse CreateOrderAndPaySync(CreateOrderAndPayRequest req)
        {
            return InternalRequestAsync<CreateOrderAndPayResponse>(req, "CreateOrderAndPay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询授权人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthUsersRequest"/></param>
        /// <returns><see cref="DescribeAuthUsersResponse"/></returns>
        public Task<DescribeAuthUsersResponse> DescribeAuthUsers(DescribeAuthUsersRequest req)
        {
            return InternalRequestAsync<DescribeAuthUsersResponse>(req, "DescribeAuthUsers");
        }

        /// <summary>
        /// 分页查询授权人列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuthUsersRequest"/></param>
        /// <returns><see cref="DescribeAuthUsersResponse"/></returns>
        public DescribeAuthUsersResponse DescribeAuthUsersSync(DescribeAuthUsersRequest req)
        {
            return InternalRequestAsync<DescribeAuthUsersResponse>(req, "DescribeAuthUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户图片下载记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadInfosRequest"/></param>
        /// <returns><see cref="DescribeDownloadInfosResponse"/></returns>
        public Task<DescribeDownloadInfosResponse> DescribeDownloadInfos(DescribeDownloadInfosRequest req)
        {
            return InternalRequestAsync<DescribeDownloadInfosResponse>(req, "DescribeDownloadInfos");
        }

        /// <summary>
        /// 获取用户图片下载记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDownloadInfosRequest"/></param>
        /// <returns><see cref="DescribeDownloadInfosResponse"/></returns>
        public DescribeDownloadInfosResponse DescribeDownloadInfosSync(DescribeDownloadInfosRequest req)
        {
            return InternalRequestAsync<DescribeDownloadInfosResponse>(req, "DescribeDownloadInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据ID查询一张图片的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public Task<DescribeImageResponse> DescribeImage(DescribeImageRequest req)
        {
            return InternalRequestAsync<DescribeImageResponse>(req, "DescribeImage");
        }

        /// <summary>
        /// 根据ID查询一张图片的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public DescribeImageResponse DescribeImageSync(DescribeImageRequest req)
        {
            return InternalRequestAsync<DescribeImageResponse>(req, "DescribeImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据关键字搜索图片列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages");
        }

        /// <summary>
        /// 根据关键字搜索图片列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
